import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CircularCheckComponent } from './circular-check.component';

describe('CircularCheckComponent', () => {
  let component: CircularCheckComponent;
  let fixture: ComponentFixture<CircularCheckComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CircularCheckComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CircularCheckComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
