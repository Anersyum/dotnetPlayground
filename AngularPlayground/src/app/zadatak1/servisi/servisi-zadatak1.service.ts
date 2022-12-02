import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ServisiZadatak1Service {

  broj1?: string;
  broj2?: string;
  rezultat?: number;

  constructor() { }


  saberiDvaBroja(broj1: string, broj2:string){
    this.rezultat=parseInt(broj1)+parseInt(broj2);
    alert(`Rezultat je: ${this.rezultat}`);

    localStorage.setItem("rezultat", String(this.rezultat));
  }

  oduzmiDVaBroja(br1: string, br2: string){
    this.rezultat=parseInt(br1)-parseInt(br2);
    alert(`Rezultat je: ${this.rezultat}`);

    localStorage.setItem("rezultat", String(this.rezultat));
  }

  pomnoziDvaBroja(br1:number, br2:number){
    this.rezultat= br1*br2;
    alert(`Rezultat je: ${this.rezultat}`);

    localStorage.setItem("rezultat", String(this.rezultat));
  }

  podijeliDvaBroja(br1:number, br2:number){
    if(br2===0)
      alert(`Dijeljenje s ${br2} nije moguće!`);
    else {
      this.rezultat=br1/br2;
      alert(`Rezulltat je: ${this.rezultat}`);
    }

    localStorage.setItem("rezultat: ",String( this.rezultat));
  }

}
