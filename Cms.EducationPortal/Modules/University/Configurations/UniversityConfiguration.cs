using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.EducationPortal.Modules.University.Configurations;

public class UniversityConfiguration : IEntityTypeConfiguration<Entities.University>
{
    public void Configure(EntityTypeBuilder<Entities.University> builder)
    {
        builder.ToTable("University");
    }
}