import { Component, Input, signal } from '@angular/core';
import { NgTemplateOutlet } from '@angular/common';
import { Project } from '../../core/models/portfolio.models';
import { RevealDirective } from '../../core/directives/reveal.directive';

const FEATURED_COUNT = 3;

@Component({
  selector: 'app-projects',
  standalone: true,
  imports: [NgTemplateOutlet, RevealDirective],
  templateUrl: './projects.html',
})
export class Projects {
  @Input({ required: true }) projects: Project[] = [];

  showAll = signal(false);
  active = signal(0);

  get featuredProjects(): Project[] {
    return this.projects.slice(0, FEATURED_COUNT);
  }

  toggleView(): void {
    this.showAll.update((v) => !v);
    this.active.set(0);
  }

  next(): void {
    this.active.update((i) => (i + 1) % this.projects.length);
  }

  prev(): void {
    this.active.update((i) => (i - 1 + this.projects.length) % this.projects.length);
  }

  goTo(i: number): void {
    this.active.set(i);
  }
}
