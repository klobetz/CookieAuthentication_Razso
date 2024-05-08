using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Model.Entities
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? UserName { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Password { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Role { get; set; }
    }
}
