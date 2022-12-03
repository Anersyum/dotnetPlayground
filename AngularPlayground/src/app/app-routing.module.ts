import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { Zadatak1Component } from "./zadatak1/zadatak1.component";
import { Zadatak2Component } from "./zadatak2/zadatak2.component";

const routes: Routes = [
  { path: "zadatak2", component: Zadatak2Component },
  { path: "zadatak1", component: Zadatak1Component },
  { path: "login", component: LoginComponent },
  { path: "", component: HomeComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
