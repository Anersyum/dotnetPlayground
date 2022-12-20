import { Component } from '@angular/core';
import { LoginService } from '../services/login.service';

@Component({
  selector: 'app-project-navigation',
  templateUrl: './project-navigation.component.html',
  styleUrls: ['./project-navigation.component.scss']
})
export class ProjectNavigationComponent {

  // isLoggedIn: boolean = this._loginService.isLoggedIn;

  constructor(protected _loginService: LoginService) {}
}
