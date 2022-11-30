/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { IspisiPodatkeService } from './ispisi-podatke.service';

describe('Service: IspisiPodatke', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [IspisiPodatkeService]
    });
  });

  it('should ...', inject([IspisiPodatkeService], (service: IspisiPodatkeService) => {
    expect(service).toBeTruthy();
  }));
});
