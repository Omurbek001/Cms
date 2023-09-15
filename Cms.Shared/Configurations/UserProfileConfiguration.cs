using Cms.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Shared.Configurations;

public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
{
    public void Configure(EntityTypeBuilder<UserProfile> builder)
    {
        builder.ToTable("UserProfiles")
            .HasOne(up => up.User)
            .WithMany()
            .HasForeignKey(up => up.UserId);

        builder.Property<string>(up => up.PhoneNumber)
            .HasMaxLength(20);
        
        builder.Property<string>(up => up.WhatsAppNumber)
            .HasMaxLength(20);

        builder.Property<string>(up => up.Address)
            .HasMaxLength(200);
        
        
        
        builder.Ignore(up => up.Roles);
    }
}