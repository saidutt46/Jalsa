using System;
using System.ComponentModel.DataAnnotations;

namespace Jalsa.Domain.Models
{
    public class RegistrationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfileName { get; set; }
        public string Location { get; set; }
        public int ColorTheme { get; set; }
        public int Gender { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
