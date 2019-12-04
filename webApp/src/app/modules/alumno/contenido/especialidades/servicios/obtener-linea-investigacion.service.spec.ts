import { TestBed } from '@angular/core/testing';

import { ObtenerLineaInvestigacionService } from './obtener-linea-investigacion.service';

describe('ObtenerLineaInvestigacionService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ObtenerLineaInvestigacionService = TestBed.get(ObtenerLineaInvestigacionService);
    expect(service).toBeTruthy();
  });
});
