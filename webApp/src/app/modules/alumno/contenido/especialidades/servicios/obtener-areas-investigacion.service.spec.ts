import { TestBed } from '@angular/core/testing';

import { ObtenerAreasInvestigacionService } from './obtener-areas-investigacion.service';

describe('ObtenerAreasInvestigacionService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ObtenerAreasInvestigacionService = TestBed.get(ObtenerAreasInvestigacionService);
    expect(service).toBeTruthy();
  });
});
