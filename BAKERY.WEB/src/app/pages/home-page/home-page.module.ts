import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomePageComponent } from './home-page.component';
import { HomePageRoutingModule } from './home-page-routing.module';
import { BunModule } from 'src/app/features/bun/bun.module';



@NgModule({
  declarations: [HomePageComponent],
  imports: [
    CommonModule,
    HomePageRoutingModule,
    BunModule
  ],
  exports: [HomePageComponent]
})
export class HomePageModule { }
