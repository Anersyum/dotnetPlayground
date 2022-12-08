import {Component, OnInit} from '@angular/core';
import {ActivatedRoute, Router} from "@angular/router";
import {GuardsService} from "../services/guards.service";
import {MacaModel} from"../models/macaModel"

@Component({
  selector: 'app-zadatak4',
  templateUrl: './zadatak4.component.html',
  styleUrls: ['./zadatak4.component.scss']
})
export class Zadatak4Component implements OnInit{

  //dugme (koje "glumi" url) koji me vodi na destinaciju (to su ustvari ruteri)
  constructor(private router: Router, private aktivnaRuta: ActivatedRoute, private guradsServis: GuardsService) {
  }

  goToAdmin() {
    this.router.navigateByUrl("admin");
  }

  goToAdminWithParams() {
    this.router.navigateByUrl("admin", {
      state: {
        param: "Ovaj tekst je spašen u window history."
      }
    });
  }

  //Dobra praksa je kada npr. nešto se upload-uje i onda se treba vratiti na HomePage
  trenutnaRuta() {
    alert(this.aktivnaRuta.toString());
  }

  dodijeliPristupAdmin(odobriPristup: boolean) {
    this.guradsServis.dodijeliPristupAdmin((odobriPristup));
  }

  ngOnInit(): void {


  }



}
