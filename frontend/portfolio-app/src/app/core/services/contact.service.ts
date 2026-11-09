import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { ContactMessageRequest } from '../models/portfolio.models';

@Injectable({ providedIn: 'root' })
export class ContactService {
  private readonly baseUrl = `${environment.apiUrl}/contact`;

  constructor(private readonly http: HttpClient) {}

  send(request: ContactMessageRequest): Observable<{ message: string; id: number }> {
    return this.http.post<{ message: string; id: number }>(this.baseUrl, request);
  }
}
