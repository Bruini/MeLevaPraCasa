import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ScorePage } from './score.page';

describe('ScorePage', () => {
  let component: ScorePage;
  let fixture: ComponentFixture<ScorePage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ScorePage],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ScorePage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
