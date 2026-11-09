using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.Models;

public class ContactMessageRequest
{
    [Required, MaxLength(120)]
    public string Name { get; set; } = string.Empty;

    [Required, EmailAddress, MaxLength(200)]
    public string Email { get; set; } = string.Empty;

    [Required, MaxLength(2000)]
    public string Message { get; set; } = string.Empty;
}

public class ContactMessage : ContactMessageRequest
{
    public int Id { get; set; }
    public DateTime SubmittedAtUtc { get; set; }
}
