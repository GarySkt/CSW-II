import { TestBed } from '@angular/core/testing';

import { ObtenerListaActividadesService } from './obtener-lista-actividades.service';

describe('ObtenerListaActividadesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ObtenerListaActividadesService = TestBed.get(ObtenerListaActividadesService);
    expect(service).toBeTruthy();
  });
});
