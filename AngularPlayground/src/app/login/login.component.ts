import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IspisiPodatkeService } from '../services/ispisi-podatke.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {

  email: string | null = localStorage.getItem("email");

  constructor(private router: Router, private activeRoute: ActivatedRoute) {}

  setAccessToProfile(canAccess: boolean) {
    localStorage.setItem("logedIn", String(canAccess));
    const message = canAccess ? "You can now access the profile link." : "You cannot access the profile link."

    alert(message);
  }

  goToProfile() {
    this.router.navigateByUrl("profile");
  }

  goToProfileWithParams() {
    this.router.navigateByUrl("profile", {
      state: {
        test: "Hello world from param!"
      }
    });
  }

  getCurrentNavigation() {
    alert(this.activeRoute.toString());
  }
}
