import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class CarService {
  constructor() {}
  auto: string= '';
  saveValues(unosAuta: string) {
    this.auto = unosAuta;

    localStorage.setItem('auto', unosAuta);
  }
}
