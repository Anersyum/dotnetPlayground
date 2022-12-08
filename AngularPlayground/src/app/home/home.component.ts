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
  imageUrl: string = "https://www.thespruceeats.com/thmb/sWPNQ7OwAJFbtTwUWZYCtvhKgCk=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/traditional-yugoslavian-rolled-burek-borek-recipe-1805900-hero-01-4e70014f61424bc0baf537e462860968.jpg";
  imageHeight: number = 300;
  imageWidth: number = 500;
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
  constructor(private _ispisServis: IspisiPodatkeService) {
    alert("Konstruktor home")
  }

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
