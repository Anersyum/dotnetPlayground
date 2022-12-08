import {Injectable} from '@angular/core';
import {ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree} from '@angular/router';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class AdminGuard implements CanActivate {

  constructor() { //zasto??
  }

  canActivate(): boolean {
    const canActivate: boolean = localStorage.getItem("logedIN") == "true";
    //(a li postoji "logedIn) ako postoji "logedIn u lokal storage i (da li je on true) ako je on true, onda vrati true
    return canActivate;
    //kad god on vrati true mi možemo pristupiti ruti (app-routing-odule.ts) na koji smo zakacili ovaj guard
    //ako ovaj guard vrati false neće se moći pristupiti ovoj ruti
    //setItem - je setovan unutar zadatak4.component.ts

    //ovo je kao neki front-end uard koji onemogućava pristup korisniku ako nije logovan

    //na jednoj ruti se može imati više gurad-ova (on je niz []) i svi moraju vratiti true da bi se moglo pristupiti toj ruti
  }

}
