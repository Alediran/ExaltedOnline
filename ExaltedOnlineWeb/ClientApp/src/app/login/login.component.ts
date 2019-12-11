import { Component, OnInit, Inject, ChangeDetectionStrategy, ViewEncapsulation } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ApiService } from '../core/api.service';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { User } from '../core/data.model';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

type ValidationErrors = {
    [key: string]: any;
}

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss'],
    encapsulation: ViewEncapsulation.None,
    changeDetection: ChangeDetectionStrategy.OnPush,
    providers: [ApiService]
})

export class LoginComponent implements OnInit {

    spresp: any;
    user: User;

    formValidation: FormGroup
    //    = this.fb.group({
    //    userName: ['', Validators.required]
    //});

    account_validation_messages = {
        'username': [
            { type: 'required', message: 'Username is required' },
            { type: 'minlength', message: 'Username must be at least 5 characters long.' },
            { type: 'maxlength', message: 'Username cannot be more than 25 characters long.' },
            { type: 'pattern', message: 'Your username must start with three letters and contain only numbers or letters.' },
            { type: 'ifUserExists', message: 'Your username has already been registered.' }
        ],
        'email': [
            { type: 'required', message: 'Email is required.' },
            { type: 'email', message: 'Enter a valid email.' },
            { type: 'ifEmailExist', message: 'Your email has already been registered.'}
        ],
        'confirm_password': [
            { type: 'required', message: 'Confirm password is required.' },
            { type: 'areNotEqual', message: 'Password does not match.' }
        ],
        'password': [
            { type: 'required', message: 'Password is required.' },
            { type: 'minlength', message: 'Password must be at least 8 characters long.' },
            { type: 'maxlength', message: 'Password cannot be more that 25 characters long.' },
            { type: 'pattern', message: 'Your password must contain at least one uppercase, one lowercase, one number and one special character.' }
        ],
        'terms': [
            { type: 'pattern', message: 'You must accept terms and conditions.' }
        ]
    };

    constructor(public dialogRef: MatDialogRef<LoginComponent>, private fb: FormBuilder, private apiService: ApiService) {
        this.user = new User();
    }

    ngOnInit() {
        this.formValidation = this.fb.group({
            userName: ['', {
                validators: Validators.compose([
                    Validators.required,
                    Validators.minLength(5),
                    Validators.maxLength(25),
                    Validators.pattern('^[a-zA-Z]{3}[a-zA-Z0-9]*$')
                ]),
                asyncValidators: this.ifUserExists.bind(this),
                updateOn: 'blur'
            }],
            email: ['', {
                validators: Validators.compose([
                    Validators.required,
                    Validators.email
                ]),
                asyncValidators: this.ifEmailExist.bind(this),
                updateOn: 'blur'                
            }],
            password: ['', {
                validators: Validators.compose([
                    Validators.required,
                    Validators.minLength(8),
                    Validators.maxLength(25),
                    Validators.pattern('^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9\-\$\%\&]+$')
                ])
            }],
            confirmPassword: ['', {
                validators: Validators.compose([
                    Validators.required,
                    this.matchValues('password')
                ])
            }]
        });
    }

    onCancelClick(): void {
        this.dialogRef.close();
    }

    saveUser() {

        this.user.userName = this.formValidation.get('userName').value;
        this.user.email = this.formValidation.get('email').value;
        this.user.password = this.formValidation.get('password').value;

        this.apiService.createUser(this.user).subscribe(resp => { return this.spresp.push(resp); });
    }

    ifUserExists(fc: AbstractControl): Promise<ValidationErrors | null> | Observable<ValidationErrors | null> {
        return this.apiService.userExists(fc.value).pipe(map((res: any) => {
            return res.model ? { ifUserExists: true } : null;
        }));
    }

    ifEmailExist(fc: AbstractControl): Promise<ValidationErrors | null> | Observable<ValidationErrors | null> {
        return this.apiService.emailExists(fc.value).pipe(map((res: any) => {
            return res.model ? { ifEmailExist: true } : null;
        }));
    }

    matchValues(
        matchTo: string // name of the control to match to
    ): (AbstractControl) => ValidationErrors | null {
        return (control: AbstractControl): ValidationErrors | null => {
            return !!control.parent &&
                !!control.parent.value &&
                control.value === control.parent.controls[matchTo].value
                ? null
                : { areNotEqual: true };
        };
    }
}
