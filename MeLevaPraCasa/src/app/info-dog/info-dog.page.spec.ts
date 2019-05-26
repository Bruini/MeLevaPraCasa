import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InfoDogPage } from './info-dog.page';

describe('InfoDogPage', () => {
  let component: InfoDogPage;
  let fixture: ComponentFixture<InfoDogPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InfoDogPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InfoDogPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
