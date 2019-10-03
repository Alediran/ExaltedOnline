import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CharmListComponent } from './charm-list.component';

describe('CharmListComponent', () => {
  let component: CharmListComponent;
  let fixture: ComponentFixture<CharmListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CharmListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CharmListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
