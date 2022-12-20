import { Cars } from './../../models/carsModel';
import { Component, OnInit } from '@angular/core';
import { CarService } from '../../services/car.service';

@Component({
  selector: 'app-lista-vozila-tab',
  templateUrl: './lista-vozila-tab.component.html',
  styleUrls: ['./lista-vozila-tab.component.css'],
})
export class ListaVozilaTabComponent implements OnInit {
  arrayCars: Array<Cars> = [];

  constructor(private _carService: CarService) {
  }

  ngOnInit() {
    this.arrayCars = JSON.parse(localStorage.getItem("listaAuta") as string);
    // this.arrayCars = this._carService.listaAuta;
    // this.arrayCars.push(
    //   {
    //     tip: 'Karavan',
    //     naziv: 'Ime1',
    //     datumKreiranja: new Date(),
    //   },
    //   {
    //     tip: 'Limuzina',
    //     naziv: 'Ime2',
    //     datumKreiranja: new Date(),
    //   },
    //   {
    //     tip: 'Džip',
    //     naziv: 'Ime3',
    //     datumKreiranja: new Date(),
    //   },
    //   {
    //     tip: 'SUV',
    //     naziv: 'Ime4',
    //     datumKreiranja: new Date(),
    //   },
    //    {
    //      tip: this.dodanoAutoBaza,
    //      naziv: '',
    //      datumKreiranja: new Date(),
    //    },
    // );
  }
}
