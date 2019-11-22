import { TestBed } from '@angular/core/testing';

import { CicloAcademicoService } from './ciclo-academico.service';

describe('CicloAcademicoService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CicloAcademicoService = TestBed.get(CicloAcademicoService);
    expect(service).toBeTruthy();
  });
});
