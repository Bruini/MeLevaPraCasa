import { Component } from '@angular/core';
import { ModalService } from '../services/modal/modal.service';

@Component({
  selector: 'app-subscribe-donation',
  templateUrl: './subscribe-donation.page.html',
  styleUrls: ['./subscribe-donation.page.scss'],
})

export class SubscribeDonationPage {

  constructor(
    private _modalService: ModalService,
  ) { }

  async abreModal() {
    const modal = await this._modalService.abreModal();
    modal.present();
  }

}
