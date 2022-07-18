import { Component, Input, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { CardDetail } from 'src/app/shared/card-detail.model';
import { CardDetailService } from 'src/app/shared/card-detail.service';

@Component({
  selector: 'app-card-details-form',
  templateUrl: './card-details-form.component.html',
  styleUrls: ['./card-details-form.component.css']
})
export class CardDetailsFormComponent implements OnInit {
  @Input() card?: CardDetail;

  cardBank: CardDetail = new CardDetail();

  constructor(public service:CardDetailService,
    private toastr:ToastrService) { } // dependency injection

  ngOnInit(): void {
    // this.service.getCardDetails()
    // .subscribe({
    //   next: (CardDetail) => {
    //     console.log(CardDetail);
    //   },
    //   error: (response) => {
    //     console.log(response);
    //   }
    // });
  }

  onSubmit(form: NgForm) {
    this.service.postCardDetails(this.cardBank)
    .subscribe({
      next: (card1) => {
        console.log(card1);
        this.resetForm(form);
        this.toastr.success('Submitted successfully', 'Bank Card Register');
      },
      error: (response) => {
        console.log(response);
      }
    }); 
  }
  
  resetForm(form:NgForm) {
    form.form.reset();
    this.service.formData = new CardDetail();
  }

}
