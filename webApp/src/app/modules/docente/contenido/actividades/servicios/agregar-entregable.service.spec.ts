import { TestBed } from '@angular/core/testing';

import { AgregarEntregableService } from './agregar-entregable.service';

describe('AgregarEntregableService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AgregarEntregableService = TestBed.get(AgregarEntregableService);
    expect(service).toBeTruthy();
  });
});
