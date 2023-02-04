import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { tap } from 'rxjs';
import { LoginModel } from '../models/loginModel';
import { TokenModel } from '../models/tokenModel';

@Component({
  selector: 'app-lgoin',
  templateUrl: './lgoin.component.html',
  styleUrls: ['./lgoin.component.scss']
})
export class LgoinComponent {

  constructor(private httpClient: HttpClient, private router: Router) {}

  login(username: string, password: string) {
    const loginData: LoginModel = {
      username: username,
      password
    };

    this.httpClient.post<TokenModel>("http://localhost:5131/api/Auth/prijava", loginData)
      .pipe(
        tap(r => {
          if (r)
          {
            localStorage.setItem("authToken", r.token!);
            //@ts-ignore
            porukaSuccess("Logovan!");
            this.router.navigateByUrl("/studenti");
          }
        })
      )
      .subscribe();
  }
}
