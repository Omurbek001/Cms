using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.ECommerce.Modules.Cart.Configurations;

public class CartConfiguration : IEntityTypeConfiguration<Cart.Entities.Cart>
{
    public void Configure(EntityTypeBuilder<Cart.Entities.Cart> builder)
    {
        builder.ToTable("Cart");
    }
}