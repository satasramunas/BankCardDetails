import { Component, Input, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { CardDetail } from 'src/app/shared/card-detail.model';
import { CardDetailService } from 'src/app/shared/card-detail.service';
import { servicesVersion } from 'typescript';
import { CardDetailsComponent } from '../card-details.component';

@Component({
  selector: 'app-card-details-form',
  templateUrl: './card-details-form.component.html',
  styleUrls: ['./card-details-form.component.css']
})
export class CardDetailsFormComponent implements OnInit {
  @Input() card?: CardDetail;

  cardBank: CardDetail = this.service.formData;

  constructor(public service:CardDetailService, component:CardDetailsComponent,
    private toastr:ToastrService) { } // dependency injection

  ngOnInit(): void {
  }

  onSubmit(form: NgForm) {
    this.service.postCardDetails(this.service.formData)
    .subscribe({
      next: (cardBank) => {
        console.log(cardBank);
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
