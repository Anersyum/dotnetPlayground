import { Router } from '@angular/router';
import { Cars } from './../../models/carsModel';
import { Component, OnInit } from '@angular/core';
import { CarService } from '../../services/car.service';

@Component({
  selector: 'app-kreiranje-vozila-tab',
  templateUrl: './kreiranje-vozila-tab.component.html',
  styleUrls: ['./kreiranje-vozila-tab.component.css'],
})
export class KreiranjeVozilaTabComponent implements OnInit {
  /*niz=['Karavan','Limuzina','Džip','SUV'];
  data=[
    {
      naziv: 'Karavan'
    },
    {
      naziv: 'Limuzina'
    },
    {
      naziv: 'Džip'
    },
    {
      naziv: 'SUV'
    }
  ];*/
  cars: Array<Cars> = [];

  constructor(private _carsService: CarService, private _router: Router) {}

  ngOnInit(): void {
    this.cars.push(
      {
        tip: 'Karavan',
      },
      {
        tip: 'Limuzina',
      },
      {
        tip: 'Džip',
      },
      {
        tip: 'SUV',
      }
    );
  }

  novoAutoNaziv: string = '';
  getValueCar(unos: string) {
    this.novoAutoNaziv = unos;
  }

  pozdravnaPoruka(unos: string, tip: string) {
    const auto: Cars = {
      naziv: unos,
      tip: tip,
      datumKreiranja: new Date()
    };

    this._carsService.saveValues(auto);
    alert(`Dodan auto: ${auto.naziv}`);

    setTimeout(() => {
      this._router.navigateByUrl('lista-vozila');
    }, 2500);
  }
}
