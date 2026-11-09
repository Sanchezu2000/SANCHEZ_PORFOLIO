import { Component, Input } from '@angular/core';
import { ManagedProject } from '../../core/models/portfolio.models';
import { RevealDirective } from '../../core/directives/reveal.directive';

@Component({
  selector: 'app-hepherion-labs',
  standalone: true,
  imports: [RevealDirective],
  templateUrl: './hepherion-labs.html',
})
export class HepherionLabs {
  @Input({ required: true }) projects: ManagedProject[] = [];

  statusClass(status: string): string {
    const s = status.toLowerCase();
    if (s.includes('progress')) return 'pm-status-active';
    if (s.includes('complet') || s.includes('done')) return 'pm-status-done';
    return '';
  }
}
