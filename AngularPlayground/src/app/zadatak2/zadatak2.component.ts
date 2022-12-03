import { Component } from '@angular/core';

@Component({
  selector: 'app-zadatak2',
  templateUrl: './zadatak2.component.html',
  styleUrls: ['./zadatak2.component.scss']
})
export class Zadatak2Component {
  rezultat: string | null=localStorage.getItem("rezultat");


  constructor() {
  }
}
