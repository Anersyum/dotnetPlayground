import { TestBed } from '@angular/core/testing';

import { ServisiZadatak1Service } from './servisi-zadatak1.service';

describe('ServisiZadatak1Service', () => {
  let service: ServisiZadatak1Service;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServisiZadatak1Service);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
