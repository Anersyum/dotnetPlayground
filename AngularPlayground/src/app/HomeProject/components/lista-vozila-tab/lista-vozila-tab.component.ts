import { Cars } from './../../models/carsModel';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-lista-vozila-tab',
  templateUrl: './lista-vozila-tab.component.html',
  styleUrls: ['./lista-vozila-tab.component.css'],
})
export class ListaVozilaTabComponent implements OnInit {
  arrayCars: Array<Cars> = [];
  dodanoAutoBaza: string | null;

  constructor() {
    this.dodanoAutoBaza = localStorage.getItem('auto');
  }

  ngOnInit() {
    this.arrayCars.push(
      {
        tip: 'Karavan',
        naziv: 'Ime1',
        datumKreiranja: new Date(),
      },
      {
        tip: 'Limuzina',
        naziv: 'Ime2',
        datumKreiranja: new Date(),
      },
      {
        tip: 'Džip',
        naziv: 'Ime3',
        datumKreiranja: new Date(),
      },
      {
        tip: 'SUV',
        naziv: 'Ime4',
        datumKreiranja: new Date(),
      },
       {
         tip: this.dodanoAutoBaza,
         naziv: '',
         datumKreiranja: new Date(),
       },
    );
  }
}
