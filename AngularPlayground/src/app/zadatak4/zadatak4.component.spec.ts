import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Zadatak4Component } from './zadatak4.component';

describe('Zadatak4Component', () => {
  let component: Zadatak4Component;
  let fixture: ComponentFixture<Zadatak4Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Zadatak4Component ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Zadatak4Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
