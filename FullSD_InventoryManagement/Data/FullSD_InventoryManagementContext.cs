using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FullSD_InventoryManagement.Domain;
using FullSD_InventoryManagement.Configurations.Entities;

namespace FullSD_InventoryManagement.Data
{
    public class FullSD_InventoryManagementContext : DbContext
    {
        public FullSD_InventoryManagementContext (DbContextOptions<FullSD_InventoryManagementContext> options)
            : base(options)
        {
        }

        public DbSet<FullSD_InventoryManagement.Domain.Item> Item { get; set; } = default!;
        public DbSet<FullSD_InventoryManagement.Domain.Branch> Branch { get; set; } = default!;
        public DbSet<FullSD_InventoryManagement.Domain.User> User { get; set; } = default!;
        public DbSet<FullSD_InventoryManagement.Domain.Order> Order { get; set; } = default!;
        public DbSet<FullSD_InventoryManagement.Domain.OrderDetail> OrderDetail { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new BranchSeed());
            builder.ApplyConfiguration(new ItemSeed());
            builder.ApplyConfiguration(new OrderDetailSeed());
            builder.ApplyConfiguration(new OrderSeed());
        }
    }
}
