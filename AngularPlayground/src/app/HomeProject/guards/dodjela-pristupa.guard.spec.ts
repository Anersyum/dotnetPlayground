import { TestBed } from '@angular/core/testing';

import { DodjelaPristupaGuard } from './dodjela-pristupa.guard';

describe('DodjelaPristupaGuard', () => {
  let guard: DodjelaPristupaGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(DodjelaPristupaGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
