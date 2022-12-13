import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VjezbeJedanComponent } from './vjezbe-jedan.component';

describe('VjezbeJedanComponent', () => {
  let component: VjezbeJedanComponent;
  let fixture: ComponentFixture<VjezbeJedanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VjezbeJedanComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(VjezbeJedanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
