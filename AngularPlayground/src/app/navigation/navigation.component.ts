import { Component } from '@angular/core';
import { Routes } from '@angular/router';
import { routes } from '../app-routing.module';


@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.scss']
})

export class NavigationComponent {
  routes: Routes = routes.filter(x => x.title); // copy and reverse and filter
}
