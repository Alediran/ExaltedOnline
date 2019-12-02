import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService} from './api.service'
import { AbstractControl, ValidationErrors } from '@angular/forms';
import { map } from 'rxjs/operators';

@Injectable()
export class UserExists {

    constructor(private apiService: ApiService) { }

    checkUser(name: string): Observable<ValidationErrors | null> {
        const obs = this.apiService.userExists(name).pipe(
            map((userExists) => {
                return !userExists ? null : { ifUserExists: true };
            })
        );

        return obs;
    }
}
