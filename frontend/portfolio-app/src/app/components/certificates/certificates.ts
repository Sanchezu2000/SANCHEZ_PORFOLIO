import { Component, EventEmitter, HostListener, Input, Output, signal } from '@angular/core';
import { Certificate } from '../../core/models/portfolio.models';
import { RevealDirective } from '../../core/directives/reveal.directive';

@Component({
  selector: 'app-certificates',
  standalone: true,
  imports: [RevealDirective],
  templateUrl: './certificates.html',
})
export class Certificates {
  @Input({ required: true }) certificates: Certificate[] = [];
  @Output() highlightSkills = new EventEmitter<string[]>();

  active = signal<number | null>(null);
  zoomed = signal<Certificate | null>(null);

  select(cert: Certificate, index: number): void {
    if (this.active() === index) {
      this.active.set(null);
      this.highlightSkills.emit([]);
      return;
    }

    this.active.set(index);
    this.highlightSkills.emit(cert.relatedSkills);
    document.getElementById('skills')?.scrollIntoView({ behavior: 'smooth', block: 'start' });
  }

  openZoom(event: Event, cert: Certificate): void {
    event.stopPropagation();
    this.zoomed.set(cert);
  }

  closeZoom(): void {
    this.zoomed.set(null);
  }

  @HostListener('document:keydown.escape')
  onEscape(): void {
    this.closeZoom();
  }
}
