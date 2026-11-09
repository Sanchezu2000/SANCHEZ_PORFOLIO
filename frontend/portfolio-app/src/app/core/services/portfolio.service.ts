import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { Certificate, Feature, ManagedProject, Profile, Project, SkillCategory } from '../models/portfolio.models';

@Injectable({ providedIn: 'root' })
export class PortfolioService {
  private readonly baseUrl = `${environment.apiUrl}/portfolio`;

  constructor(private readonly http: HttpClient) {}

  getProfile(): Observable<Profile> {
    return this.http.get<Profile>(`${this.baseUrl}/profile`);
  }

  getProjects(): Observable<Project[]> {
    return this.http.get<Project[]>(`${this.baseUrl}/projects`);
  }

  getHepherionLabsProjects(): Observable<ManagedProject[]> {
    return this.http.get<ManagedProject[]>(`${this.baseUrl}/hepherion-labs`);
  }

  getSkills(): Observable<SkillCategory[]> {
    return this.http.get<SkillCategory[]>(`${this.baseUrl}/skills`);
  }

  getCertificates(): Observable<Certificate[]> {
    return this.http.get<Certificate[]>(`${this.baseUrl}/certificates`);
  }

  getFeatures(): Observable<Feature[]> {
    return this.http.get<Feature[]>(`${this.baseUrl}/features`);
  }
}
