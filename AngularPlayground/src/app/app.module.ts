import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { IspisiPodatkeService } from './services/ispisi-podatke.service';
import { LoginComponent } from './login/login.component';
import { FormsModule } from '@angular/forms';
import { NavigationComponent } from './navigation/navigation.component';
import { Zadatak1Component } from './zadatak1/zadatak1.component';
import { Zadatak2Component } from './zadatak2/zadatak2.component';
import { Zadatak3Component } from './zadatak3/zadatak3.component';
import { ProfileComponent } from './profile/profile.component';
import { Zadatak4Component } from './zadatak4/zadatak4.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
    NavigationComponent,
    Zadatak1Component,
    Zadatak2Component,
    Zadatak3Component,
    ProfileComponent,
    Zadatak4Component
  ],
  imports: [
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
