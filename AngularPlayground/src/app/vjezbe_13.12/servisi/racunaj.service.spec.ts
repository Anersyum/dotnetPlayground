import { TestBed } from '@angular/core/testing';

import { RacunajService } from './racunaj.service';

describe('RacunajService', () => {
  let service: RacunajService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RacunajService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
