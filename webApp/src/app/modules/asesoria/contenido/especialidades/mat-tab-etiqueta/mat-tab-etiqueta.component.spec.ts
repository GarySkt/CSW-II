import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MatTabEtiquetaComponent } from './mat-tab-etiqueta.component';

describe('MatTabEtiquetaComponent', () => {
  let component: MatTabEtiquetaComponent;
  let fixture: ComponentFixture<MatTabEtiquetaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MatTabEtiquetaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MatTabEtiquetaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
