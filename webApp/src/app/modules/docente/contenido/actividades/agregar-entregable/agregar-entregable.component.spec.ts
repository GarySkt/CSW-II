import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AgregarEntregableComponent } from './agregar-entregable.component';

describe('AgregarEntregableComponent', () => {
  let component: AgregarEntregableComponent;
  let fixture: ComponentFixture<AgregarEntregableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AgregarEntregableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AgregarEntregableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
