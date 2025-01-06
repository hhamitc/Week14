using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace _01_IdentityAndDataProtectionPractice.Models;

public class User : IdentityUser
{
    [Required(ErrorMessage = "Email alanı zorunludur")]
    [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz")]
    public override string Email { get; set; } = string.Empty;
} 