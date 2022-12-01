import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { IspisiPodatkeService } from '../services/ispisi-podatke.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})

export class HomeComponent {

  userModel = {
    mail: "",
    password: "",
  };
  // private _ispisServis: IspisiPodatkeService;
  // constructor(_ispisServis: IspisiPodatkeService) {
  //   this._ispisServis = _ispisServis;
  // }
  constructor(private _ispisServis: IspisiPodatkeService) {}

  // ispis(email: HTMLInputElement, password: HTMLInputElement) {
  //   this._ispisServis.ispisiPodatke(email.value, password.value);
  // }

  ispis() {
    this._ispisServis.ispisiPodatke(this.userModel.mail, this.userModel.password);
  }
}
