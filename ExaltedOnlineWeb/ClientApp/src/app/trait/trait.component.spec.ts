import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TraitComponent } from './trait.component';
import { CircularCheckComponent } from '../circular-check/circular-check.component';

describe('TraitComponent', () => {
  let component: TraitComponent;
  let fixture: ComponentFixture<TraitComponent>;

  beforeEach(async(() => {
      TestBed.configureTestingModule({
          declarations: [TraitComponent, CircularCheckComponent]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TraitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
