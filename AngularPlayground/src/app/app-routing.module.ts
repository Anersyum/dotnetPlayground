import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProfileGuardGuard } from './guards/profile-guard.guard';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { ProfileComponent } from './profile/profile.component';
import { Zadatak1Component } from "./zadatak1/zadatak1.component";
import { Zadatak2Component } from "./zadatak2/zadatak2.component";
import { Zadatak3Component } from './zadatak3/zadatak3.component';

export const routes: Routes = [
  { path: "zadatak3", component: Zadatak3Component, title: "Zadatak 3" },
  { path: "zadatak2", component: Zadatak2Component, title: "Zadatak 2" },
  { path: "zadatak1", component: Zadatak1Component, title: "Zadatak 1" },
  { path: "profile", component: ProfileComponent, title: "Profile", canActivate: [ProfileGuardGuard] },
  { path: "login", component: LoginComponent, title: "Login" },
  { path: "", component: HomeComponent, title: "Home" },
  { path: "**", component: HomeComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule {
}
