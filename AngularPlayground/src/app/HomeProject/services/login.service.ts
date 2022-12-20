import { Injectable } from '@angular/core';
import { Login } from '../models/loginModel';

@Injectable({
  providedIn: 'root',
})
export class LoginService {
  constructor() {}
  login: Login = {
    username: '',
    password: '',
  };
  saveValues(username: string,password:string) {
    this.login.username=username;
    this.login.password=password;

    localStorage.setItem("username", username);
    localStorage.setItem( "password", password);
  }

}
