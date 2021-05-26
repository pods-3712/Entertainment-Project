import { TestBed } from '@angular/core/testing';

import { EntquestionandanswersService } from './entquestionandanswers.service';

describe('EntquestionandanswersService', () => {
  let service: EntquestionandanswersService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(EntquestionandanswersService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
