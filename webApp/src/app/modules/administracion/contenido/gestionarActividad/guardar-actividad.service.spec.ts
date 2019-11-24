import { TestBed } from '@angular/core/testing';

import { GuardarActividadService } from './guardar-actividad.service';

describe('GuardarActividadService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: GuardarActividadService = TestBed.get(GuardarActividadService);
    expect(service).toBeTruthy();
  });
});
