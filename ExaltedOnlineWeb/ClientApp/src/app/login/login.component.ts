import { Component, OnInit, Inject, ChangeDetectionStrategy, ViewEncapsulation } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ApiService } from '../core/api.service';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { User } from '../core/data.model';
import { UserNameValidator } from '../core/custom.validators';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

//export interface DialogData {
//    userId: BigInteger;
//    userName: string;
//    password: string;
//}

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

    formValidation = this.fb.group({
        userName: ['', Validators.required]
    });

    account_validation_messages = {
        'username': [
            { type: 'required', message: 'Username is required' },
            { type: 'minlength', message: 'Username must be at least 5 characters long' },
            { type: 'maxlength', message: 'Username cannot be more than 25 characters long' },
            { type: 'pattern', message: 'Your username must start with three letters and contain only numbers or letters.' },
            { type: 'ifUserExists', message: 'Your username has already been taken' }
        ],
        'email': [
            { type: 'required', message: 'Email is required' },
            { type: 'pattern', message: 'Enter a valid email' }
        ],
        'confirm_password': [
            { type: 'required', message: 'Confirm password is required' },
            { type: 'areEqual', message: 'Password mismatch' }
        ],
        'password': [
            { type: 'required', message: 'Password is required' },
            { type: 'minlength', message: 'Password must be at least 5 characters long' },
            { type: 'pattern', message: 'Your password must contain at least one uppercase, one lowercase, and one number' }
        ],
        'terms': [
            { type: 'pattern', message: 'You must accept terms and conditions' }
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
                    Validators.pattern('^[a-zA-Z]{3}[a-zA-Z0-9]*$'),
                ]),
                asyncValidators: Validators.compose([
                    this.ifUserExists
                ]),
                updateOn: 'blur'
            }],
            password: ['', { validators: Validators.required, updateOn: 'blur' }]
        });
    }

    onCancelClick(): void {
        this.dialogRef.close();
    }

    saveUser() {
        this.apiService.createUser(this.user).subscribe(resp => { return this.spresp.push(resp); });
    }

    ifUserExists(fc: AbstractControl): AsyncValidatorFn {
        return this.apiService.userExists(fc.value).pipe(
                map(res => {
                    return res ? { ifUserExists: true } : null;
                }));
        }
}
