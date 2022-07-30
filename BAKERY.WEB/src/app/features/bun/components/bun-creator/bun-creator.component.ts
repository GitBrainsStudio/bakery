import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatBottomSheetRef } from '@angular/material/bottom-sheet';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ReplaySubject } from 'rxjs';
import { BunService } from '../../services/bun.service';

@Component({
  selector: 'app-bun-creator',
  templateUrl: './bun-creator.component.html',
  styleUrls: ['./bun-creator.component.css']
})
export class BunCreatorComponent implements OnInit {

  form:FormGroup;
  destroy: ReplaySubject<boolean> = new ReplaySubject<boolean>(1);
  
  constructor(
    private formBuilder:FormBuilder, 
    private bunService:BunService,
    private matBottomSheetRef:MatBottomSheetRef<BunCreatorComponent>,
    private matSnackBar:MatSnackBar) {
    this.form = this.formBuilder.group(
      {
        count: ['', [Validators.required, Validators.pattern("^[0-9]*$"), Validators.max(30)]]
      }
    );
   }

  ngOnInit(): void {
  }

  ngOnDestroy(): void {
    this.destroy.next(true);
    this.destroy.complete();
  }

  formSubmit()
  {
    if (!this.form.invalid)
    {
      var count = this.form.controls['count'].value;
      this.bunService.generateRandomBunsByCount(count)
      .subscribe(v => {
        this.matBottomSheetRef.dismiss('Success');
        this.matSnackBar.open(`Булочки в количестве ${ count } шт. готовы 👍`, undefined, { duration: 2000 })
      })
    }
  }
}
