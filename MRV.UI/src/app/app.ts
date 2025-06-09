import { Component } from '@angular/core';
import { LeadDetails } from "./lead-details/lead-details";

@Component({
  selector: 'app-root',
  imports: [LeadDetails],
  templateUrl: './app.html',
  styles: [],
})
export class App {
  protected title = 'MRV.UI';
}
