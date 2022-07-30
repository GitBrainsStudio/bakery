import { Component, OnInit } from '@angular/core';
import { Bun } from '../../models/bun.model';
import { BunService } from '../../services/bun.service';
import { filter, interval, ReplaySubject, switchMap, takeUntil} from 'rxjs';
import { MatBottomSheet } from '@angular/material/bottom-sheet';
import { BunCreatorComponent } from '../bun-creator/bun-creator.component';

@Component({
  selector: 'app-bun-collection',
  templateUrl: './bun-collection.component.html',
  styleUrls: ['./bun-collection.component.css']
})
export class BunCollectionComponent implements OnInit {

  buns:Bun[] | null = null;
  bunsMatTableColumns: string[] = ['type', 'bakingDate', 'saleDeadline', 'hoursCountForSale', 'beginPrice', 'currentPrice', 'timeToChangeCurrentPrice', 'nextCurrentPrice'];
  destroy: ReplaySubject<boolean> = new ReplaySubject<boolean>(1);
  constructor(private bunService:BunService, private matBottomSheet:MatBottomSheet) { }

  ngOnInit(): void {
    interval(3000).pipe(
      switchMap(() => this.bunService.getAll()))
      .subscribe(buns => this.buns = buns);
  }

  ngOnDestroy(): void {
    this.destroy.next(true);
    this.destroy.complete();
  }

  getTableData()
  {
    this.bunService.getAll()
    .pipe(takeUntil(this.destroy))
      .subscribe(buns => this.buns = buns);
  }

  openBunCreatorBottomSheet()
  {
    const bottomSheet = this.matBottomSheet.open(BunCreatorComponent);
    bottomSheet.afterDismissed()
    .pipe(takeUntil(this.destroy))
    .pipe(
      filter(result => result === 'Success'),
      switchMap(() => this.bunService.getAll()))
      .subscribe(buns => this.buns = buns)
  }
}
