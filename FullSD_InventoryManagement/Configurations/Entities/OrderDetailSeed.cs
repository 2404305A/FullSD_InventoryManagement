using FullSD_InventoryManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullSD_InventoryManagement.Configurations.Entities
{
    public class OrderDetailSeed : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasData(
                // Items belonging to Order #1
                new OrderDetail
                {
                    Id = 1,
                    OrderID = 1,
                    ItemID = 1, 
                    Quantity = 50,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new OrderDetail
                {
                    Id = 2,
                    OrderID = 1,
                    ItemID = 2,
                    Quantity = 20,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },


                new OrderDetail
                {
                    Id = 3,
                    OrderID = 2, 
                    ItemID = 1,
                    Quantity = 10,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
