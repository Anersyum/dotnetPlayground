import { Injectable } from '@angular/core';
import { Login } from '../models/loginModel';

@Injectable({
  providedIn: 'root',
})
export class LoginService {
  constructor() {}
  // login: Login = {
  //   username: '',
  //   password: '',
  // };
  // loginData: Login = {
  //   username: "admin",
  //   password: "admin"
  // };

  isUserLoggedIn: boolean = this.isLoggedIn();

  saveValues(username: string,password:string) {
    // this.login.username=username;
    // this.login.password=password;

    localStorage.setItem("username", username);
    localStorage.setItem("password", password);
    this.isUserLoggedIn = true;
  }

  private isLoggedIn(): boolean
  {
    return localStorage.getItem("username") != null && localStorage.getItem("password") != null;
  }

  // saveValues(loginData: Login)
  // {
  //   localStorage.setItem("username", loginData.username);
  //   localStorage.setItem( "password", loginData.password);
  // }

  // login(username: string, password: string): boolean
  // {
  //   const isCorrectData: boolean = username == this.loginData.username && password == this.loginData.password;

  //   localStorage.setItem("logedIn", String(isCorrectData));

  //   return isCorrectData;
  // }

  logout() {
    localStorage.removeItem("username");
    localStorage.removeItem("password");
    this.isUserLoggedIn = false;
  }
}
