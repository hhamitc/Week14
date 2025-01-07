using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace _02_JwtPractice.Models
{
    public class User
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
} 