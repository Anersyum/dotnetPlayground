import { Component, OnInit } from '@angular/core';
import { UserModel } from '../models/userModel';
import { UserService } from '../services/user-service.service';
import {UppercaseServiceService} from "../services/uppercase-service.service";

@Component({
  selector: 'app-zadatak3',
  templateUrl: './zadatak3.component.html',
  styleUrls: ['./zadatak3.component.scss']
})
export class Zadatak3Component implements OnInit {

  users: Array<UserModel> = [];

  constructor(private userService: UserService, private _upperCaseSevice: UppercaseServiceService) { }


  ngOnInit() {
    // ovdje su dodijeljeni user-i tako da je users array popunjen
    this.userService.getAllUsers().subscribe(o => this.users = o);
  }

  prikaziPodatke:boolean=false;
  prikaziTabelu(checkbox: HTMLInputElement) {
    this.prikaziPodatke=checkbox.checked;
  }

  uneseniTekst:string="";
  getInputValue(value: string){
    //this.uneseniTekst=value;
    this._upperCaseSevice.pretvoriUneseniText((value));
  }


}
