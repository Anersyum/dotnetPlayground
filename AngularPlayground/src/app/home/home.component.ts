import { AfterViewInit, Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IspisiPodatkeService } from '../services/ispisi-podatke.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})

export class HomeComponent implements OnInit, AfterViewInit, OnDestroy {

  prikaziLogin: boolean = false;
  userModel = {
    mail: "",
    password: "",
  };
  textCollection: Array<string>= [
    "Sara",
    "Amor",
    "Ines",
    "Jasko",
    "Miška"
  ];

  objectCollection = [
    {
      name: "Amor",
      surname: "osmic"
    },
    {
      name: "Sara",
      surname: "Šahinpašić"
    },
    {
      name: "Miška",
      surname: "Miškić"
    }
  ];

  // private _ispisServis: IspisiPodatkeService;
  // constructor(_ispisServis: IspisiPodatkeService) {
  //   this._ispisServis = _ispisServis;
  // }
  constructor(private _ispisServis: IspisiPodatkeService) {}

  ngOnDestroy(): void {
    alert("Uništeno")
  }

  ngAfterViewInit(): void {
    alert("After view")
  }

  ngOnInit(): void {
    alert("Inicijalizacija");
  }

  // ispis(email: HTMLInputElement, password: HTMLInputElement) {
  //   this._ispisServis.ispisiPodatke(email.value, password.value);
  // }

  ispis() {
    this._ispisServis.ispisiPodatke(this.userModel.mail, this.userModel.password);
  }

  aktivirajLogin(checkbox: HTMLInputElement) {
    this.prikaziLogin = checkbox.checked;
  }

  test() {
    alert(this.userModel.mail)
  }
}
