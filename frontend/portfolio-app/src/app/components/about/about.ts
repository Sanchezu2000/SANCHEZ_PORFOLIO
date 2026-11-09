import { Component, Input } from '@angular/core';
import { Feature } from '../../core/models/portfolio.models';
import { RevealDirective } from '../../core/directives/reveal.directive';

@Component({
  selector: 'app-about',
  standalone: true,
  imports: [RevealDirective],
  templateUrl: './about.html',
})
export class About {
  @Input({ required: true }) features: Feature[] = [];
}
