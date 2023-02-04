import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';

import { StudentiComponent } from './rs1/studenti/studenti.component';
import { LgoinComponent } from './rs1/lgoin/lgoin.component';
import { RegisterComponent } from './rs1/register/register.component';
import { NavComponent } from './rs1/nav/nav.component';
import { moduleDeclarations } from './module-declarations';
import { RS1HomeComponent } from './rs1/home/home.component';

import { NavigationComponent } from './navigation/navigation.component';
import { Zadatak1Component } from './zadatak1/zadatak1.component';
import { Zadatak2Component } from './zadatak2/zadatak2.component';
import { Zadatak3Component } from './zadatak3/zadatak3.component';
import { ProfileComponent } from './profile/profile.component';
import { Zadatak4Component } from './zadatak4/zadatak4.component';
import { AdminComponent } from './admin/admin.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { ProjectNavigationComponent } from './HomeProject/project-navigation/project-navigation.component';
import { VjezbeJedanComponent } from './vjezbe_13.12/vjezbe-jedan/vjezbe-jedan.component';
import { HomeTabComponent } from './HomeProject/components/home-tab/home-tab.component';
import { KreiranjeVozilaTabComponent } from './HomeProject/components/kreiranje-vozila-tab/kreiranje-vozila-tab.component';
import { ListaVozilaTabComponent } from './HomeProject/components/lista-vozila-tab/lista-vozila-tab.component';
import { HomeComponent } from './home/home.component';
import { IspisiPodatkeService } from './services/ispisi-podatke.service';
import { LoginComponent } from './login/login.component';

// const declarations = moduleDeclarations.concat([
//   StudentiComponent,
//   LgoinComponent,
//   RegisterComponent,
//   NavComponent,
//   AppComponent,
//   RS1HomeComponent
// ]);

@NgModule({
  declarations:
  [
    StudentiComponent,
    LgoinComponent,
    RegisterComponent,
    NavComponent,
    AppComponent,
    RS1HomeComponent,
    // staro
    HomeTabComponent,
    KreiranjeVozilaTabComponent,
    ListaVozilaTabComponent,
    // AppComponent,
    HomeComponent,
    LoginComponent,
    NavigationComponent,
    Zadatak1Component,
    Zadatak2Component,
    Zadatak3Component,
    ProfileComponent,
    Zadatak4Component,
    AdminComponent,
    PageNotFoundComponent,
    ProjectNavigationComponent,
    VjezbeJedanComponent,
  ],
  imports: [
    FormsModule,
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [
    // IspisiPodatkeService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
