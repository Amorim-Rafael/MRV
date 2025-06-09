import { Component, OnInit } from '@angular/core';
import { LeadDetailsInvited } from "./lead-details-invited/lead-details-invited";
import { LeadDetailsAccepted } from "./lead-details-accepted/lead-details-accepted";

@Component({
  selector: 'app-lead-details',
  imports: [LeadDetailsInvited, LeadDetailsAccepted],
  templateUrl: './lead-details.html',
  styles: ``
})
export class LeadDetails {
  
}
