import { Component, OnInit, Inject, ChangeDetectionStrategy, ViewEncapsulation } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { MatPasswordStrengthComponent } from '@angular-material-extensions/password-strength';
import { ApiService } from '../core/api.service';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { User } from '../core/data.model';

//export interface DialogData {
//    userId: BigInteger;
//    userName: string;
//    password: string;
//}

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

    constructor(public dialogRef: MatDialogRef<LoginComponent>, private apiService: ApiService) {
        this.user = new User();
    }

    ngOnInit() {
    }

    onCancelClick(): void {
        this.dialogRef.close();
    }

    saveUser() {        
        this.apiService.createUser(this.user).subscribe(resp => { return this.spresp.push(resp); });
    }
}
