import { Component, OnInit, signal } from '@angular/core';
import { forkJoin } from 'rxjs';
import { PortfolioService } from './core/services/portfolio.service';
import { Certificate, Feature, ManagedProject, Profile, Project, SkillCategory } from './core/models/portfolio.models';
import { Navbar } from './components/navbar/navbar';
import { Hero } from './components/hero/hero';
import { Projects } from './components/projects/projects';
import { HepherionLabs } from './components/hepherion-labs/hepherion-labs';
import { About } from './components/about/about';
import { Skills } from './components/skills/skills';
import { Certificates } from './components/certificates/certificates';
import { Contact } from './components/contact/contact';
import { Footer } from './components/footer/footer';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [Navbar, Hero, Projects, HepherionLabs, About, Skills, Certificates, Contact, Footer],
  templateUrl: './app.html',
})
export class App implements OnInit {
  protected readonly loading = signal(true);
  protected readonly loadError = signal(false);

  protected profile?: Profile;
  protected projects: Project[] = [];
  protected hepherionLabsProjects: ManagedProject[] = [];
  protected features: Feature[] = [];
  protected skills: SkillCategory[] = [];
  protected certificates: Certificate[] = [];
  protected readonly highlightedSkills = signal<string[]>([]);

  constructor(private readonly portfolioService: PortfolioService) {}

  ngOnInit(): void {
    forkJoin({
      profile: this.portfolioService.getProfile(),
      projects: this.portfolioService.getProjects(),
      hepherionLabsProjects: this.portfolioService.getHepherionLabsProjects(),
      features: this.portfolioService.getFeatures(),
      skills: this.portfolioService.getSkills(),
      certificates: this.portfolioService.getCertificates(),
    }).subscribe({
      next: ({ profile, projects, hepherionLabsProjects, features, skills, certificates }) => {
        this.profile = profile;
        this.projects = projects;
        this.hepherionLabsProjects = hepherionLabsProjects;
        this.features = features;
        this.skills = skills;
        this.certificates = certificates;
        this.loading.set(false);
      },
      error: () => {
        this.loadError.set(true);
        this.loading.set(false);
      },
    });
  }
}
