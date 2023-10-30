using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.ECommerce.Modules.Category.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category.Entities.Category>
{
    public void Configure(EntityTypeBuilder<Category.Entities.Category> builder)
    {
        builder.ToTable("Category");
    }
}