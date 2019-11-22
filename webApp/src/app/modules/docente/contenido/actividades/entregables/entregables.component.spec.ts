import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EntregablesComponent } from './entregables.component';

describe('EntregablesComponent', () => {
  let component: EntregablesComponent;
  let fixture: ComponentFixture<EntregablesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EntregablesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EntregablesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
