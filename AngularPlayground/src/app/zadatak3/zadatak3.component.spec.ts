/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { Zadatak3Component } from './zadatak3.component';

describe('Zadatak3Component', () => {
  let component: Zadatak3Component;
  let fixture: ComponentFixture<Zadatak3Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Zadatak3Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Zadatak3Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
