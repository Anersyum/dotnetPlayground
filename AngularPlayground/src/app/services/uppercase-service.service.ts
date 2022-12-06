import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UppercaseServiceService {

  constructor() { }


  pretvoriUneseniText(uneseniTekst1: string) {
    const velikaSlova:string=uneseniTekst1.toUpperCase();
    alert(`${velikaSlova}`);
    //console.log(velikaSlova);
    //document.write(velikaSlova);
    localStorage.setItem("rezultatFunkcije", velikaSlova);
  }
}
