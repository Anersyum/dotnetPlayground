import { CanActivate } from '@angular/router';
import { Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root',
})
export class DodjelaPristupaGuard implements CanActivate {

  canActivate(): boolean {
    const username: string | null = localStorage.getItem('username');
    const password: string | null = localStorage.getItem('password');

    return username != null && password != null;
  }
}
