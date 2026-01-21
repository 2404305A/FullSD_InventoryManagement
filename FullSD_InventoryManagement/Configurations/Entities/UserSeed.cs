using FullSD_InventoryManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullSD_InventoryManagement.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<FullSD_InventoryManagementUser>
    {
        public void Configure(EntityTypeBuilder<FullSD_InventoryManagementUser> builder)
        {
            var hasher = new PasswordHasher<FullSD_InventoryManagementUser>();
            builder.HasData(
                new FullSD_InventoryManagementUser
                {
                    Id = "d40252e1-7e47-4998-a6f2-c872657c5223",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString()
                }
            );
        }
    }
}

