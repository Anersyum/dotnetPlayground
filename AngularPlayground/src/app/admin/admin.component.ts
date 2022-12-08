import { Component } from '@angular/core';
import {Router} from "@angular/router";

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.scss']
})
export class AdminComponent {
  param: string | null | undefined = window.history.state.param;

  constructor(private router:Router) {
  }

  gotToZadatak4() {
    this.router.navigateByUrl("zadatak4");
  }
}
