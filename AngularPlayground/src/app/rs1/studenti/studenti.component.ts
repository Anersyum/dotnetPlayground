import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { tap } from 'rxjs';
import { TokenModel } from '../models/tokenModel';

@Component({
  selector: 'app-studenti',
  templateUrl: './studenti.component.html',
  styleUrls: ['./studenti.component.scss'],

})
export class StudentiComponent implements OnInit {

  constructor(private httpClient: HttpClient, private router: Router) {}

  ngOnInit(): void {
    const token: TokenModel = {
      token: localStorage.getItem("authToken")
    };
    this.httpClient.post<boolean>("http://localhost:5131/api/Auth/checkIfLoggedIn", token)
      .pipe(
        tap(this.checkLogin)
      )
      .subscribe();
  }
  // prijavljen => token
  // nisi prijavljen => error
  // čekiraj token

  checkLogin(result: boolean)
  {
    if (!result)
    {
      this.router.navigateByUrl("/prijava");
      //@ts-ignore
      porukaError("Niste prijavljeni!"); // todo: projveri zašto ne radi
    }
  }
}
