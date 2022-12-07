import { Component } from '@angular/core';
import { Routes } from '@angular/router';
import { routes } from '../app-routing.module';


@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.scss']
})

export class NavigationComponent {
  routes: Routes = routes.copyWithin(0, 0).filter(x => x.title).reverse(); // copy and reverse and filter
}
