import { Component, Input, signal } from '@angular/core';
import { SkillCategory } from '../../core/models/portfolio.models';
import { RevealDirective } from '../../core/directives/reveal.directive';

@Component({
  selector: 'app-skills',
  standalone: true,
  imports: [RevealDirective],
  templateUrl: './skills.html',
})
export class Skills {
  @Input({ required: true }) skills: SkillCategory[] = [];
  @Input() highlightedSkills: string[] = [];

  selected = signal<ReadonlySet<string>>(new Set());

  cdnIconUrl(slug: string): string {
    return `https://cdn.simpleicons.org/${slug}`;
  }

  isSelected(name: string): boolean {
    return this.selected().has(name);
  }

  toggleSelected(name: string): void {
    const next = new Set(this.selected());
    if (next.has(name)) {
      next.delete(name);
    } else {
      next.add(name);
    }
    this.selected.set(next);
  }
}
