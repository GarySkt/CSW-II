import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TablaActividadesComponent } from './tabla-actividades.component';

describe('TablaActividadesComponent', () => {
  let component: TablaActividadesComponent;
  let fixture: ComponentFixture<TablaActividadesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TablaActividadesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TablaActividadesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
