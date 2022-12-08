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

  imageUrl: string = "https://www.thespruceeats.com/thmb/sWPNQ7OwAJFbtTwUWZYCtvhKgCk=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/traditional-yugoslavian-rolled-burek-borek-recipe-1805900-hero-01-4e70014f61424bc0baf537e462860968.jpg";
  imageHeight: number = 300;
  imageWidth: number = 500;
  activateColor: boolean = false;
  styleFromComponent: string = "background-color: pink;";
  showInlineStyle: boolean = false;
  colors: Array<string> = ["blue", "pink", "purple", "green", "violet", "red", "yellow"];
  nizVrijednosti: Array<number> = [1, 2, 34, 4, 5, 67, 10];
  //dugme (koje "glumi" url) koji me vodi na destinaciju (to su ustvari ruteri)
  constructor(private router: Router, private aktivnaRuta: ActivatedRoute, private guradsServis: GuardsService) {
  }

  //Dobra praksa je kada npr. nešto se upload-uje i onda se treba vratiti na HomePage
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

  trenutnaRuta() {
    alert(this.aktivnaRuta.toString());
  }

  dodijeliPristupAdmin(odobriPristup: boolean) {
    this.guradsServis.dodijeliPristupAdmin((odobriPristup));
  }

  ngOnInit(): void {


  }

  showValue($event: KeyboardEvent) {
    if ($event.key.toLowerCase() == "enter") {
      alert(($event.target as HTMLInputElement).value);
    }
  }

  showValueEventFiltering(input: HTMLInputElement) {
    alert(input.value);
  }

  showMessage(message: string) {
    alert(message);
  }

  showMessageNoBubbling($event: MouseEvent, message: string) {
    $event.stopPropagation();
    this.showMessage(message);
  }


}
