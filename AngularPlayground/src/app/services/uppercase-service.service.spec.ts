import { TestBed } from '@angular/core/testing';

import { UppercaseServiceService } from './uppercase-service.service';

describe('UppercaseServiceService', () => {
  let service: UppercaseServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UppercaseServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
