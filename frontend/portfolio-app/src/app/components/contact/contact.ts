import { Component, inject, Input, signal } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { ContactService } from '../../core/services/contact.service';
import { Profile } from '../../core/models/portfolio.models';
import { RevealDirective } from '../../core/directives/reveal.directive';

@Component({
  selector: 'app-contact',
  standalone: true,
  imports: [ReactiveFormsModule, RevealDirective],
  templateUrl: './contact.html',
})
export class Contact {
  @Input({ required: true }) profile!: Profile;

  private readonly fb = inject(FormBuilder);
  private readonly contactService = inject(ContactService);

  protected readonly submitting = signal(false);
  protected readonly statusMessage = signal<string | null>(null);
  protected readonly statusIsError = signal(false);

  readonly form = this.fb.group({
    name: ['', [Validators.required, Validators.maxLength(120)]],
    email: ['', [Validators.required, Validators.email]],
    message: ['', [Validators.required, Validators.maxLength(2000)]],
  });

  onSubmit(): void {
    if (this.form.invalid) {
      this.form.markAllAsTouched();
      return;
    }

    this.submitting.set(true);
    this.statusMessage.set(null);

    this.contactService.send(this.form.getRawValue() as { name: string; email: string; message: string }).subscribe({
      next: (response) => {
        this.statusIsError.set(false);
        this.statusMessage.set(response.message);
        this.form.reset();
        this.submitting.set(false);
      },
      error: () => {
        this.statusIsError.set(true);
        this.statusMessage.set('Something went wrong sending your message. Please try again later.');
        this.submitting.set(false);
      },
    });
  }
}
