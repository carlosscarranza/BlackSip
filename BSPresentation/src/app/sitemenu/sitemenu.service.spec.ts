import { TestBed } from '@angular/core/testing';

import { SitemenuService } from './sitemenu.service';

describe('SitemenuService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SitemenuService = TestBed.get(SitemenuService);
    expect(service).toBeTruthy();
  });
});
