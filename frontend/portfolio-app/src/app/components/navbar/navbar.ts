import { Component, HostListener, OnInit, signal } from '@angular/core';

const SECTION_IDS = ['home', 'about', 'skills', 'projects', 'hepherion-labs', 'certificates', 'contact'];
const NAVBAR_OFFSET = 120;

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [],
  templateUrl: './navbar.html',
})
export class Navbar implements OnInit {
  protected readonly isOpen = signal(false);
  protected readonly activeSection = signal('home');

  ngOnInit(): void {
    this.updateActiveSection();
  }

  toggleMenu(): void {
    this.isOpen.update((open) => !open);
  }

  closeMenu(): void {
    this.isOpen.set(false);
  }

  @HostListener('window:scroll')
  onScroll(): void {
    this.updateActiveSection();
  }

  private updateActiveSection(): void {
    const scrollPos = window.scrollY + NAVBAR_OFFSET;
    let current = SECTION_IDS[0];

    for (const id of SECTION_IDS) {
      const el = document.getElementById(id);
      if (el && el.offsetTop <= scrollPos) {
        current = id;
      }
    }

    if (this.activeSection() !== current) {
      this.activeSection.set(current);
    }
  }
}
