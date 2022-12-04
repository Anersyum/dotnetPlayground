import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ServisiZadatak1Service {

  // ova polja su generalno višak jer ne prenosimo nikakve informacije na druge komponente
  // broj1?: string;
  // broj2?: string;
  // rezultat?: number; #1

  constructor() { }

  // general comment: formatiranje koda da bude bolje

  // u svakoj metodi je promijenjeno sa field this.rezultat na lokalnu varijablu rezultat jer nema potrebe za setanjem
  // field-a u ovom servisu (za neke druge potrebe bi možda imalo smisla). Field na koji mislim je označen sa #1
  // isto tako nema potrebe ni za broj1 i broj2 field-ovima jer te brojeve dobijamo od komponente
  saberiDvaBroja(broj1: string, broj2: string){
    const rezultat: number = parseInt(broj1) + parseInt(broj2);
    alert(`Rezultat je: ${rezultat}`); // ovaj alert i ne treba ako već praviš kalkulator

    localStorage.setItem("rezultat", rezultat.toString());
    return rezultat;
  }

  oduzmiDVaBroja(br1: string, br2: string){
    const rezultat: number=parseInt(br1)-parseInt(br2);
    alert(`Rezultat je: ${rezultat}`);

    localStorage.setItem("rezultat", String(rezultat));
    return rezultat;
  }

  pomnoziDvaBroja(br1:number, br2:number){
    const rezultat: number= br1*br2;
    alert(`Rezultat je: ${rezultat}`);

    localStorage.setItem("rezultat", String(rezultat));
    return rezultat;
  }

  podijeliDvaBroja(br1:number, br2:number) {
    let rezultat: number = 0;
    if(br2===0)
      alert(`Dijeljenje s ${br2} nije moguće!`);
    else {
      rezultat=br1/br2;
      alert(`Rezulltat je: ${rezultat}`);
      localStorage.setItem("rezultat: ",String(rezultat));
    }

    return rezultat;
  }
}
