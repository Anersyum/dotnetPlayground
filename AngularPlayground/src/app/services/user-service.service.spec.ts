/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
// @ts-ignore
import { UserServiceService } from './user-service.service';

'.angular/services/user-sevice.service';

describe('Service: UserService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [UserServiceService]
    });
  });

  it('should ...', inject([UserServiceService], (service: UserServiceService) => {
    expect(service).toBeTruthy();
  }));
});
