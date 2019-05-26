import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { SubscribeDonationPage } from './subscribe-donation.page';

const routes: Routes = [
  {
    path: '',
    component: SubscribeDonationPage
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    RouterModule.forChild(routes)
  ],
  declarations: [SubscribeDonationPage]
})

export class SubscribeDonationPageModule {}
