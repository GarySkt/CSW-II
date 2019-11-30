import { TestBed } from '@angular/core/testing';

import { EliminarActividadService } from './eliminar-actividad.service';

describe('EliminarActividadService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: EliminarActividadService = TestBed.get(EliminarActividadService);
    expect(service).toBeTruthy();
  });
});
