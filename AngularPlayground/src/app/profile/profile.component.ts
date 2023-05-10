import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { tap } from 'rxjs';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent {
  param: string | null | undefined = window.history.state?.test;
  text: string | null | undefined;

  constructor(private httpclient: HttpClient) {}

  callApiToTest() {
    this.httpclient.post<string>("http://localhost:5131/test", "meho",
    {
      headers: {
        'Content-Type': "application/json"
      }
    })
    .pipe(
      tap(s => this.param = s)
    )
    .subscribe();
  }
}
