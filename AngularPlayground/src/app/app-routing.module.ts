import { DodjelaPristupaGuard } from './HomeProject/guards/dodjela-pristupa.guard';

import { VjezbeJedanComponent } from './vjezbe_13.12/vjezbe-jedan/vjezbe-jedan.component';
import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProfileGuardGuard } from './guards/profile-guard.guard';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { ProfileComponent } from './profile/profile.component';
import { Zadatak1Component } from "./zadatak1/zadatak1.component";
import { Zadatak2Component } from "./zadatak2/zadatak2.component";
import { Zadatak3Component } from './zadatak3/zadatak3.component';
import { Zadatak4Component } from './zadatak4/zadatak4.component';
import {AdminComponent} from "./admin/admin.component";
import {AdminGuard} from "./guards/admin-guard.service";
import {PageNotFoundComponent} from "./page-not-found/page-not-found.component";
import { KreiranjeVozilaTabComponent } from './HomeProject/components/kreiranje-vozila-tab/kreiranje-vozila-tab.component';
import { ListaVozilaTabComponent } from './HomeProject/components/lista-vozila-tab/lista-vozila-tab.component';
import { HomeTabComponent } from './HomeProject/components/home-tab/home-tab.component';
import { RS1HomeComponent } from './rs1/home/home.component';
import { LgoinComponent } from './rs1/lgoin/lgoin.component';
import { RegisterComponent } from './rs1/register/register.component';
import { StudentiComponent } from './rs1/studenti/studenti.component';
import { DataGuardGuard } from './guards/data-guard.guard';

const oldRoutes = [
  { path:"admin", component:AdminComponent, title:"Admin-Zadatak 4,", canActivate:[AdminGuard] },
  { path: "zadatak4", component: Zadatak4Component, title: "Zadatak 4" },
  { path: "zadatak3", component: Zadatak3Component, title: "Zadatak 3" },
  { path: "zadatak2", component: Zadatak2Component, title: "Zadatak 2" },
  { path: "zadatak1", component: Zadatak1Component, title: "Zadatak 1" },
  { path: "profile", component: ProfileComponent, title: "Profile", canActivate: [ProfileGuardGuard] },
  { path: "login", component: LoginComponent, title: "Login" },
  { path: "", component: HomeComponent, title: "Home" },
  {path:"lista-vozila", component:ListaVozilaTabComponent, title:"Lista vozila"},
  {path:"kreiraj-vozilo", component:KreiranjeVozilaTabComponent, title:"Kreiranje vozila", canActivate:[DodjelaPristupaGuard]},
  {path:"home", component:HomeTabComponent, title:"Home"},
  //{ path: "vjezbe-jedan", component: VjezbeJedanComponent, title:"Vjezbe 1" }, //WildCard
  { path: "**", component: PageNotFoundComponent }, //WildCard
]

export const routes: Routes = [
  { path: "", component: RS1HomeComponent },
  { path: "prijava", component: LgoinComponent },
  { path: "registracija", component: RegisterComponent },
  { path: "studenti", component: StudentiComponent, canActivate: [DataGuardGuard] },
  { path: "**", component: RS1HomeComponent }
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule {
}
