import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { LeadService } from '../../shared/lead.service';

@Component({
  selector: 'app-lead-details-invited',
  imports: [CommonModule],
  templateUrl: './lead-details-invited.html',
  styles: `hr {
    margin: 1rem 0;
    color: grey;
    background-color: grey;
    border: 0;
    opacity: 0.25;
  }`
})
export class LeadDetailsInvited implements OnInit {
  
  constructor(public service: LeadService) { }

  ngOnInit(): void {
    this.service.getLeadsInvited();
  }

  updateName(id: number) {
    console.log('updateName:'+ id)
    this.service.updateLeadStatus(id);
  }
}
