using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.ECommerce.Modules.Commodity.Configurations;

public class CommodityConfiguration : IEntityTypeConfiguration<Entities.Commodity>
{
    public void Configure(EntityTypeBuilder<Entities.Commodity> builder)
    {
        builder.ToTable("Commodity");
        builder.Property(i => i.Caption).HasMaxLength(50);
        
    }
}