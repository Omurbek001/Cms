using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.ECommerce.Modules.OrderItem.Configurations;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem.Entities.OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem.Entities.OrderItem> builder)
    {
        builder.ToTable("OrderItem");
    }
}