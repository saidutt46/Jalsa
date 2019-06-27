using System;
namespace Jalsa.Domain.Models
{
    public class UserInfo
    {
        public string Id { get; set; }
        public string ProfileName { get; set; }
        public string IdentityId { get; set; }

        public string Location { get; set; }
        public int Gender { get; set; }
        public int ColorTheme { get; set; }

        public AppUser Identity { get; set; } // Navigation Property
    }
}
