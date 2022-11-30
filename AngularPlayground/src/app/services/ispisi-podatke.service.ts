import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class IspisiPodatkeService {

  email?: string;
  password?: string;

  constructor() { }

  ispisiPodatke(email: string, password: string): string {
    alert(`Vaš email je: ${email}, vaš password je ${password}`);
    this.email = email;
    this.password = password;

    return this.email;
  }
}
