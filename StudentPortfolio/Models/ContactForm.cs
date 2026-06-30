using System.ComponentModel.DataAnnotations;

namespace StudentPortfolio.Models;

public class ContactForm
{
    [Required, StringLength(80)]
    public string Name { get; set; } = string.Empty;

    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required, StringLength(120)]
    public string Subject { get; set; } = string.Empty;

    [Required, StringLength(1500, MinimumLength = 20)]
    public string Message { get; set; } = string.Empty;
}
