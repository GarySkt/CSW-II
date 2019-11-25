import { TestBed } from '@angular/core/testing';

import { EscuelaService } from './escuela.service';

describe('EscuelaService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: EscuelaService = TestBed.get(EscuelaService);
    expect(service).toBeTruthy();
  });
});
