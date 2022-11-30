import { Component } from '@angular/core';
import { IspisiPodatkeService } from '../services/ispisi-podatke.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})

export class HomeComponent {

  // private _ispisServis: IspisiPodatkeService;
  // constructor(_ispisServis: IspisiPodatkeService) {
  //   this._ispisServis = _ispisServis;
  // }
  constructor(private _ispisServis: IspisiPodatkeService) {}

  ispis(email: HTMLInputElement, password: HTMLInputElement) {
    email.value += " ovo je stvarno mail";

    this._ispisServis.ispisiPodatke(email.value, password.value);
  }
}
