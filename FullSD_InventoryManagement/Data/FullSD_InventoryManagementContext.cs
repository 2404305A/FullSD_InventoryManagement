using FullSD_InventoryManagement.Configurations.Entities;
using FullSD_InventoryManagement.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FullSD_InventoryManagement.Data
{
    public class FullSD_InventoryManagementContext(DbContextOptions<FullSD_InventoryManagementContext> options) : IdentityDbContext<FullSD_InventoryManagementUser>(options)
    {
        public DbSet<FullSD_InventoryManagement.Domain.Item> Item { get; set; } = default!;
        public DbSet<FullSD_InventoryManagement.Domain.Branch> Branch { get; set; } = default!;
        public DbSet<FullSD_InventoryManagement.Domain.User> User { get; set; } = default!;
        public DbSet<FullSD_InventoryManagement.Domain.Order> Order { get; set; } = default!;
        public DbSet<FullSD_InventoryManagement.Domain.OrderDetail> OrderDetail { get; set; } = default!;
        public DbSet<FullSD_InventoryManagement.Domain.BranchInventory> BranchInventory { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new BranchSeed());
            builder.ApplyConfiguration(new ItemSeed());
            builder.ApplyConfiguration(new OrderDetailSeed());
            builder.ApplyConfiguration(new OrderSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new DomainUserSeed());
        }
    }
}
