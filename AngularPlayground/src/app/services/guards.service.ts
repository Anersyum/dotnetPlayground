import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class GuardsService {

  constructor() {
  }

  dodijeliPristupAdmin(odobriPristup: boolean) {
    localStorage.setItem("logedIN", String(odobriPristup));
    const poruka: string = odobriPristup ? "Odobren pristup!" : "Onemoućen pristup!";

    alert(poruka);
  }
}
