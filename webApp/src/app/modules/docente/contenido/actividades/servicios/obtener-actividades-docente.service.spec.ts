import { TestBed } from '@angular/core/testing';

import { ObtenerActividadesDocenteService } from './obtener-actividades-docente.service';

describe('ObtenerActividadesDocenteService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ObtenerActividadesDocenteService = TestBed.get(ObtenerActividadesDocenteService);
    expect(service).toBeTruthy();
  });
});
