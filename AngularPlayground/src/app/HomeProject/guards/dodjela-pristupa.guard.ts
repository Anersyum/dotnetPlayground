import { Router } from '@angular/router';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class DodjelaPristupaGuard {
  constructor(private _router: Router) {}

  dodijeliPristup(odobriPristup: boolean) {
    localStorage.setItem('logedIN', String(odobriPristup));
    const poruka: string = odobriPristup
      ? 'Odobren pristup!'
      : 'Onemoućen pristup!';

    alert(poruka);

    if (odobriPristup === true) {
      this._router.navigateByUrl('kreiraj-vozilo');
    }
  }
}
