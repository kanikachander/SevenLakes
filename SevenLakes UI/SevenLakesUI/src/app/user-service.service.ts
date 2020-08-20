import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from './User.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

  constructor(private http: HttpClient) { }

  apiUrl: string = "http://localhost:62736/api/User/";

  public Login(user: any): Observable<any> {
    const url = this.apiUrl + "Login"
    return this.http.post(url, user, {
      responseType: "text" as "json",
    });
  }

  public ResetPassword(user: any): Observable<any> {
    const url = this.apiUrl + "ResetPassword"
    return this.http.post(url, user, {
      responseType: "text" as "json",
    });
  }
}
