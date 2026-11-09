import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-footer',
  standalone: true,
  imports: [],
  templateUrl: './footer.html',
})
export class Footer {
  @Input({ required: true }) fullName!: string;
  protected readonly year = new Date().getFullYear();
}
