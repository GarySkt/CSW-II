import { TestBed } from '@angular/core/testing';

import { GestionarActividadService } from './gestionar-actividad.service';

describe('GestionarActividadService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: GestionarActividadService = TestBed.get(GestionarActividadService);
    expect(service).toBeTruthy();
  });
});
