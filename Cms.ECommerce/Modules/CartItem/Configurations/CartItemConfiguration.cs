using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.ECommerce.Modules.CartItem.Configurations;

public class CartItemConfiguration : IEntityTypeConfiguration<CartItem.Entities.CartItem>
{
    public void Configure(EntityTypeBuilder<CartItem.Entities.CartItem> builder)
    {
        builder.ToTable("CartItem");
    }
}