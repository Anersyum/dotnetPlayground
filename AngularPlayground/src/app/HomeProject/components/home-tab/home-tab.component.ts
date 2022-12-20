import { DodjelaPristupaGuard } from './../../guards/dodjela-pristupa.guard';
import { Router } from '@angular/router';
import { Login } from '../../models/loginModel';
import { Component, OnInit } from '@angular/core';
import { LoginService } from '../../services/login.service';

@Component({
  selector: 'app-home-tab',
  templateUrl: './home-tab.component.html',
  styleUrls: ['./home-tab.component.css'],
})
export class HomeTabComponent implements OnInit {
  constructor(
    private _router: Router,
    private _loginService: LoginService,
    private _guardPristup: DodjelaPristupaGuard
  ) {}
  ngOnInit() {}

  login: Login = {
    username: '',
    password: '',
  };

  slova= /^[A-Za-z]+$/;

  getValueUsername(unosUsername: string) {
    this.login.username = unosUsername;
  }
  getValuePassword(unosPassword: string) {
    this.login.password = unosPassword;
  }
  logIn(odobrenjePristupa: boolean) {
    this._loginService.saveValues(this.login.username, this.login.password);
    if(this.login.username.match(this.slova))
    {
      this._guardPristup.dodijeliPristup(odobrenjePristupa);
      alert(`Welcome ${this.login.username}`);
    }
    else
    alert(`Onemogucen pristup! Unesite tražene podatke!`);
  }
}
