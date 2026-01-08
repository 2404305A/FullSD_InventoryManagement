using FullSD_InventoryManagement.Data;
using Microsoft.AspNetCore.Identity;

namespace FullSD_InventoryManagement.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<FullSD_InventoryManagementUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<FullSD_InventoryManagementUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
