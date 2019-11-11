import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MatTabContenidoComponent } from './mat-tab-contenido.component';

describe('MatTabContenidoComponent', () => {
  let component: MatTabContenidoComponent;
  let fixture: ComponentFixture<MatTabContenidoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MatTabContenidoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MatTabContenidoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
