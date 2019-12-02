import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError, map } from 'rxjs/operators';
import { User, BoolModel } from './data.model';


@Injectable({
  providedIn: 'root'
})

export class ApiService {    

    baseUrl: String = 'http://localhost:8082/api';  //'https://exaltedapi.azurewebsites.net/api';

    constructor(private httpClient: HttpClient) { }

    httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json'})
    }

    //Charm Methods
    public getCharm<CharmModel>(id: Number) {
        const url = `${this.baseUrl}/Charms/`;       

        return this.httpClient.get<CharmModel>(url + id).pipe(catchError(this.handleError));
    }

    public getCharms<CharmModel>() {
        const url = `${this.baseUrl}/Charms`;

        return this.httpClient.get<CharmModel>(url);
    }

    //UserMethods
    public userExists(userName: string) {
        const url = `${this.baseUrl}/Users/Exists/`;

        return this.httpClient.get(url + userName).pipe(catchError(this.handleError));
    }

    public createUser(user: User): Observable<User> {
        const url = `${this.baseUrl}/Users/Register`;

        return this.httpClient.post<User>(url, user, this.httpOptions).pipe(catchError(this.handleError));

    }

    // Handle API errors
    handleError(error: HttpErrorResponse) {
        if (error.error instanceof ErrorEvent) {
            // A client-side or network error occurred. Handle it accordingly.
            console.error('An error occurred:', error.error.message);
        } else {
            // The backend returned an unsuccessful response code.
            // The response body may contain clues as to what went wrong,
            console.error(
                `Backend returned code ${error.status}, ` +
                `body was: ${error.error}`);
        }
        // return an observable with a user-facing error message
        return throwError(
            'Something bad happened; please try again later.');
    };
} 
