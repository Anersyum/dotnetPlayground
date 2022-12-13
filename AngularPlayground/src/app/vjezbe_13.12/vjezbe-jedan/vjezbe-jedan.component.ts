import { RacunajService } from './../servisi/racunaj.service';
import { Brojevi } from './../models/brojevi';
import { Component } from '@angular/core';

@Component({
  selector: 'app-vjezbe-jedan',
  templateUrl: './vjezbe-jedan.component.html',
  styleUrls: ['./vjezbe-jedan.component.scss'],
})


export class VjezbeJedanComponent {

  constructor(private _racunServis:RacunajService){}
  brojevi: Brojevi = {
    broj1: 0,
    broj2: 0,
    rezultat: 0,
  };

podijeli() {
  if (this.brojevi.broj2 === 0)
  alert('Dijeljenje 0 nije moguće');
  else
this.brojevi.rezultat= this._racunServis.podijeli( this.brojevi.broj1!, this.brojevi.broj2!);
}
pomnozi() {
  this.brojevi.rezultat=this._racunServis.pomnozi(this.brojevi.broj1!, this.brojevi.broj2!);
}
oduzmi() {
  this.brojevi.rezultat=this._racunServis.oduzmi(this.brojevi.broj1!, this.brojevi.broj2!);
}
saberi() {
  this.brojevi.rezultat=this._racunServis.saberi(this.brojevi.broj1!, this.brojevi.broj2!);
}
/*
int saberi(int br1, int br2){
  retrun br1+br2;
}
*/



}
