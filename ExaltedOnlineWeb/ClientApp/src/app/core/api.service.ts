import { Injectable } from "@angular/core";
import {
  HttpClient,
  HttpHeaders,
  HttpErrorResponse,
} from "@angular/common/http";
import { Observable, throwError } from "rxjs";
import { retry, catchError, map } from "rxjs/operators";
import { User, BoolModel } from "./model/data.model";

@Injectable({
  providedIn: "root",
})
export class ApiService {
  baseUrl: String = "http://localhost:81/api";

  constructor(private httpClient: HttpClient) {}

  //Charm Methods
  public getCharm<CharmModel>(id: Number): Observable<CharmModel> {
    const method = `/Charms/${id}`;

    return this.get<CharmModel>(method);
  }

  public getCharms<CharmModel>(): Observable<CharmModel> {
    const method = `/Charms`;

    return this.get<CharmModel>(method);
  }

  //UserMethods
  public userExists(userName: string): Observable<BoolModel> {
    const method = `/Users/Exists/${userName}`;

    return this.get<BoolModel>(method);
  }

  public emailExists(email: string): Observable<BoolModel> {
    const method = `Users/MailExists/${email}`;

    return this.get<BoolModel>(method);
  }

  public createUser(user: User): Observable<User> {
    const method = `/Users/Register`;

    return this.post<User>(method, user);
  }

  private get<T>(method: string) {
    const url = `${this.baseUrl}/${method}`;
    return this.httpClient.get<T>(url).pipe(catchError(this.handleError));
  }

  private post<T>(method: string, content: T): Observable<T> {
    const url = `${this.baseUrl}`;

    const httpOptions = {
      headers: new HttpHeaders({ "Content-Type": "application/json" }),
    };

    return this.httpClient
      .post<T>(url, content, httpOptions)
      .pipe(catchError(this.handleError));
  }

  // Handle API errors
  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      console.error("An error occurred:", error.error.message);
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong,
      console.error(
        `Backend returned code ${error.status}, ` + `body was: ${error.error}`
      );
    }
    // return an observable with a user-facing error message
    return throwError("Something bad happened; please try again later.");
  }
}
