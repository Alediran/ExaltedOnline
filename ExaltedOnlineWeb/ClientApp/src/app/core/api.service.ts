import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError, map } from 'rxjs/operators';
import { CharmModel, CharmModelAdapter, Charm, CharmAdapter } from './charm.model';


@Injectable({
  providedIn: 'root'
})

export class ApiService {    

    baseUrl: String = 'https://exaltedapi.azurewebsites.net/api';

    constructor(private httpClient: HttpClient) { }

    httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json'})
    }

    public getCharm<CharmModel>(id: Number) {
        const url = `${this.baseUrl}/Charms/`;       

        return this.httpClient.get<CharmModel>(url + id);
    }

    public getCharms<CharmModel>() {
        const url = `${this.baseUrl}/Charms`;

        return this.httpClient.get<CharmModel>(url);
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
