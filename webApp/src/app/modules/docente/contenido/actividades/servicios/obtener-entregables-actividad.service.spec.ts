import { TestBed } from '@angular/core/testing';

import { ObtenerEntregablesActividadService } from './obtener-entregables-actividad.service';

describe('ObtenerEntregablesActividadService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ObtenerEntregablesActividadService = TestBed.get(ObtenerEntregablesActividadService);
    expect(service).toBeTruthy();
  });
});
