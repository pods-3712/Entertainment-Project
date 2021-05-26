import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EntquestionandanswersComponent } from './entquestionandanswers.component';

describe('EntquestionandanswersComponent', () => {
  let component: EntquestionandanswersComponent;
  let fixture: ComponentFixture<EntquestionandanswersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EntquestionandanswersComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EntquestionandanswersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
