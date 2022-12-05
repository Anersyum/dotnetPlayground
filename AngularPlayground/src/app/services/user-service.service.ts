import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { UserModel } from '../models/userModel';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  baseUrl: string = `${environment.baseUrl}`;

  constructor(private httpClient: HttpClient) { }

  getAllUsers(): Observable<Array<UserModel>> {
    return this.httpClient.get<Array<UserModel>>(`${this.baseUrl}/users`);
  }
}
