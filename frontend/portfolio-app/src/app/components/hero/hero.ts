import { Component, Input } from '@angular/core';
import { Profile } from '../../core/models/portfolio.models';
import { RevealDirective } from '../../core/directives/reveal.directive';

@Component({
  selector: 'app-hero',
  standalone: true,
  imports: [RevealDirective],
  templateUrl: './hero.html',
})
export class Hero {
  @Input({ required: true }) profile!: Profile;
}
