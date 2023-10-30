using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Shared.Modules.Image.Configurations;

public class ImageConfiguration : IEntityTypeConfiguration<Entities.Image>
{
    public void Configure(EntityTypeBuilder<Entities.Image> builder)
    {
        builder.ToTable("Image");
    }
}