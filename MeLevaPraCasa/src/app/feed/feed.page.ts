import { Component, OnInit } from '@angular/core';
import { PetService } from '../services/pet/pet.service';
import { Pet } from '../models/pet';

@Component({
  selector: 'app-feed',
  templateUrl: 'feed.page.html',
  styleUrls: ['feed.page.scss']
})
export class FeedPage implements OnInit {

  pets: Pet[];

  ngOnInit() {
    this.obterPets();
  }

  constructor(
    private _petService: PetService
  ) { }

  obterPets() {
    this._petService.getPets()
      .subscribe(response => {
        this.pets = response;
      });
  }

}
