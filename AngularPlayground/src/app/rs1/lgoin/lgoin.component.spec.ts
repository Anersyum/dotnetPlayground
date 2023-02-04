import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LgoinComponent } from './lgoin.component';

describe('LgoinComponent', () => {
  let component: LgoinComponent;
  let fixture: ComponentFixture<LgoinComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LgoinComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LgoinComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
