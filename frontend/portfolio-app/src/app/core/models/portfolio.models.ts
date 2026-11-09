export interface Profile {
  firstName: string;
  lastName: string;
  title: string;
  summary: string;
  email: string;
  location: string;
  gitHubUrl: string;
  linkedInUrl: string;
  cvUrl: string;
}

export interface Project {
  id: number;
  title: string;
  description: string;
  tags: string[];
  imageUrl: string;
  gitHubUrl: string;
  liveUrl: string;
  liveLabel: string;
}

export interface ManagedProject {
  id: number;
  title: string;
  description: string;
  role: string;
  status: string;
  tags: string[];
  imageUrl: string;
  liveUrl: string;
  liveLabel: string;
  color?: string;
  color2?: string;
}

export interface SkillItem {
  name: string;
  iconType: 'cdn' | 'custom';
  icon: string;
  projectCount: number;
}

export interface SkillCategory {
  title: string;
  icon: string;
  items: SkillItem[];
}

export interface Certificate {
  icon: string;
  title: string;
  description: string;
  imageUrl: string;
  relatedSkills: string[];
}

export interface Feature {
  icon: string;
  title: string;
  description: string;
}

export interface ContactMessageRequest {
  name: string;
  email: string;
  message: string;
}
