import { Injectable } from '@angular/core';
import {Router} from "@angular/router";

@Injectable({
  providedIn: 'root'
})
export class GuardsService {

  constructor(private router:Router) {
  }

  dodijeliPristupAdmin(odobriPristup: boolean) {
    localStorage.setItem("logedIN", String(odobriPristup));
    const poruka: string = odobriPristup ? "Odobren pristup!" : "Onemoućen pristup!";

    alert(poruka);

    this.router.navigateByUrl("admin");
  }
}
