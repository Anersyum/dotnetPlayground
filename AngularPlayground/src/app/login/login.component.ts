import { Component } from '@angular/core';
import { IspisiPodatkeService } from '../services/ispisi-podatke.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {

  constructor(public _ispisServis: IspisiPodatkeService) {}
}
