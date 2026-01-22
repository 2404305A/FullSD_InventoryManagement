using FullSD_InventoryManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullSD_InventoryManagement.Configurations.Entities
{
    public class DomainUserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    // This email must match the one in UserSeed.cs
                    Username = "admin@localhost.com",
                    EmailAddress = "admin@localhost.com",
                    BranchID = 1, // Assign Admin to 'Pasir Ris' (ID: 1)
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                }
            );
        }
    }
}