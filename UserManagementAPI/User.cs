using System.ComponentModel.DataAnnotations;

namespace UserManagementAPI.Models
{
    public class User
    {
        public int Id { get; set; }          // User ID
        [Required]
        public string FirstName { get; set; } = string.Empty;   // First Name
        [Required]
        public string LastName { get; set; } = string.Empty;    // Last Name
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;       // Email Address
    }
}
