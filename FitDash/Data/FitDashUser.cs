using Microsoft.AspNetCore.Identity;

namespace FitDash.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class FitDashUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
