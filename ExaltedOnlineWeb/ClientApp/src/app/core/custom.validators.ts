import { AsyncValidatorFn, ValidationErrors, AbstractControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ApiService } from './api.service';

export class UserNameValidator {
    static apiService: any;

    constructor(private apiService: ApiService) {

    }
    static ifUserExists(fc: AbstractControl): AsyncValidatorFn {
        return (control: AbstractControl) => {
            return this.apiService.userExists(fc.value)
                .map(res => {
                    return res ? { ifUserExists: true } : null;
                });
        };
    }
}
