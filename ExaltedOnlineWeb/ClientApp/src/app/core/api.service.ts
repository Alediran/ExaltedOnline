import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError, map } from 'rxjs/operators';
import { Charm, CharmAdapter } from './charm.model';


@Injectable({
  providedIn: 'root'
})

export class ApiService {    

    baseUrl: String = 'http://localhost:8082/api';

    constructor(private httpClient: HttpClient, private adapter: CharmAdapter) { }

    httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json'})
    }

    public getCharm(id: Number): Observable<Charm> {
        const url = `${this.baseUrl}/Charms/`;

        return this.httpClient.get(url + id).pipe(
            map((data: any) => data.map(item => this.adapter.adapt(item))),
        );
    }

    public getCharms(): Observable<Charm[]> {
        const url = `${this.baseUrl}/Charms`;

        return this.httpClient.get(url).pipe(
            map((data: any[]) => data.map(item => this.adapter.adapt(item))),
        );
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
