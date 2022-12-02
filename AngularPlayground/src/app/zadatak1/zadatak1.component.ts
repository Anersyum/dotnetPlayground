import { Component } from '@angular/core';
import {ServisiZadatak1Service} from'../zadatak1/servisi/servisi-zadatak1.service';

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
    matematickaOperacija: ""
  };

  constructor(private _izracunajServis: ServisiZadatak1Service) {
  }
  saberi() {
    this.userModel.rezultat=parseInt( this.userModel.broj1)+parseInt(this.userModel.broj2);
  }
  oduzmi(){
    this.userModel.rezultat=parseInt( this.userModel.broj1)-parseInt(this.userModel.broj2);
  }
  saberi_servis() {
    this.saberi();
     this._izracunajServis.saberiDvaBroja(this.userModel.broj1, this.userModel.broj2);
  }

  oduzmi_servis() {
    this.oduzmi();
    this._izracunajServis.oduzmiDVaBroja(this.userModel.broj1, this.userModel.broj2);
  }

  pomnozi(){
    this.userModel.rezultat=parseInt( this.userModel.broj1) *parseInt( this.userModel.broj2);
  }
  pomnozi_servis() {
    this.pomnozi();
    this._izracunajServis.pomnoziDvaBroja(Number(this.userModel.broj1), Number(this.userModel.broj2));
  }

  podijeli()
  {
    if(parseInt( this.userModel.broj2)===0){
      alert("Dijeljenje nulom nije moguće!")
    }
    this.userModel.rezultat=parseInt( this.userModel.broj1) /parseInt( this.userModel.broj2);
  }
  podijeli_servis() {
  this.podijeli();
  this._izracunajServis.pomnoziDvaBroja(Number(this.userModel.broj1), Number(this.userModel.broj2));
  }
}
