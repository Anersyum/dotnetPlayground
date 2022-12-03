import { Component } from '@angular/core';
import { ServisiZadatak1Service } from '../services/servisi-zadatak1.service';

@Component({
  selector: 'app-zadatak1',
  templateUrl: './zadatak1.component.html',
  styleUrls: ['./zadatak1.component.scss']
})
export class Zadatak1Component {

  userModel={
    broj1:"",
    broj2:"",
    rezultat:0,
    matematickaOperacija: "" // obzirom da se ova varijabla nigdje ne koristi, ne treba je ni kreirati
  };

  constructor(private _izracunajServis: ServisiZadatak1Service) {
  }
  saberi() {
    this.userModel.rezultat = this._izracunajServis.saberiDvaBroja(this.userModel.broj1, this.userModel.broj2);
  }
  oduzmi(){
    this.userModel.rezultat=this._izracunajServis.oduzmiDVaBroja(this.userModel.broj1, this.userModel.broj2);
  }

  // višak
  saberi_servis() {
    this.saberi();
    this._izracunajServis.saberiDvaBroja(this.userModel.broj1, this.userModel.broj2);
  }

  // višak
  oduzmi_servis() {
    this.oduzmi();
    this._izracunajServis.oduzmiDVaBroja(this.userModel.broj1, this.userModel.broj2);
  }

  pomnozi(){
    this.userModel.rezultat=this._izracunajServis.pomnoziDvaBroja(Number(this.userModel.broj1), Number(this.userModel.broj2));
  }

  // višak jer već ima metoda pomnozi i tu možemo pozvati servis, to vrijedi i za ostale metode
  pomnozi_servis() {
    this.pomnozi();
    this._izracunajServis.pomnoziDvaBroja(Number(this.userModel.broj1), Number(this.userModel.broj2));
  }

  podijeli()
  {
    if(parseInt(this.userModel.broj2)===0){
      alert("Dijeljenje nulom nije moguće!");
      return; // dodan return
    }
    this.userModel.rezultat=this._izracunajServis.podijeliDvaBroja(Number(this.userModel.broj1), Number(this.userModel.broj2));
  }

  // višak
  podijeli_servis() {
    this.podijeli();
    this._izracunajServis.pomnoziDvaBroja(Number(this.userModel.broj1), Number(this.userModel.broj2));
  }
}
