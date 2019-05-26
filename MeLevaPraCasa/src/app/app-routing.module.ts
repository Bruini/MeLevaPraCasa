import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    loadChildren: './tabs/tabs.module#TabsPageModule'
  },
  {
    path: 'home',
    loadChildren: './home/home.module#HomePageModule'
  },
  {
    path: 'subscribe-ado',
    loadChildren: './subscribe-ado/subscribe-ado.module#SubscribeAdoPageModule'
  },
  {
    path: 'subscribe-donation',
    loadChildren: './subscribe-donation/subscribe-donation.module#SubscribeDonationPageModule'
  },
  { path: 'info-dog', loadChildren: './info-dog/info-dog.module#InfoDogPageModule' },

];
@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule {}
