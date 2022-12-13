import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class RacunajService {

  constructor() { }

  podijeli(broj1:number,broj2:number):number {
    return broj1/broj2;
  }
  pomnozi(broj1:number,broj2:number):number {
    return broj1*broj2;
  }
  oduzmi(broj1:number,broj2:number):number {
    return broj1-broj2;
  }
  saberi(broj1:number,broj2:number):number {
    return broj1+broj2;
  }

}
