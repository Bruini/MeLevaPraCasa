import { Component, OnInit } from '@angular/core';
import { PetService } from '../services/pet/pet.service';
import { Pet } from '../models/pet';

@Component({
  selector: 'app-score',
  templateUrl: 'score.page.html',
  styleUrls: ['score.page.scss']
})

export class ScorePage implements OnInit {

  pets: Pet[];

  constructor(
    private _petService: PetService
  ) { }

  ngOnInit() {
    this.obterScore();
  }

  obterScore() {
    this._petService.getScore()
      .subscribe(response => {
        this.pets = response;
      });
  }

}
