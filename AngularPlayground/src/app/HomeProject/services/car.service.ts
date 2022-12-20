import { Injectable } from '@angular/core';
import { Cars } from '../models/carsModel';

@Injectable({
  providedIn: 'root',
})
export class CarService {
  constructor() {}

  // listaAuta: Array<Cars> = [];

  saveValues(car: Cars) {
    // this.listaAuta.push(car);
    const listaAuta: string | null = localStorage.getItem("listaAuta");

    if (listaAuta == null)
    {
      const tmpLista: Array<Cars> = [];
      tmpLista.push(car);
      localStorage.setItem("listaAuta", JSON.stringify(tmpLista));
      return;
    }

    const tmpLista: Array<Cars> = JSON.parse(listaAuta);

    tmpLista.push(car);

    localStorage.setItem("listaAuta", JSON.stringify(tmpLista));
  }
}
