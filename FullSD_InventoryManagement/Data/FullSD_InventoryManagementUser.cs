using Microsoft.AspNetCore.Identity;

namespace FullSD_InventoryManagement.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class FullSD_InventoryManagementUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
