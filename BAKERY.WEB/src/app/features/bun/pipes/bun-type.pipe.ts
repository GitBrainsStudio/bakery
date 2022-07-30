import { Pipe, PipeTransform } from '@angular/core';
import { BunType } from '../enums/bun-type.enum';

@Pipe({
  name: 'bunTypePipe'
})
export class BunTypePipe implements PipeTransform {

  transform(source: BunType | undefined): string {
    if (source == null){
      return '';
    }

    switch (source) {
      case BunType.Baguette: return 'Багет';
      case BunType.Croissant: return 'Круасан';
      case BunType.LongLoaf: return 'Батон';
      case BunType.Pretzel: return 'Крендель';
      case BunType.SourCreamCake: return 'Сметанник';
      default: return String(source);
    }
  }

}