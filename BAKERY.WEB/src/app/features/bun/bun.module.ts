import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BunCollectionComponent } from './components/bun-collection/bun-collection.component';
import { MaterialModule } from '../material/material.module';
import { BunCreatorComponent } from './components/bun-creator/bun-creator.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BunTypePipe } from './pipes/bun-type.pipe';



@NgModule({
  declarations: [BunCollectionComponent, BunCreatorComponent, BunTypePipe],
  imports: [
    CommonModule,
    MaterialModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports: [BunCollectionComponent],
})
export class BunModule { }
