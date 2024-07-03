using Asparagus.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Asparagus.Persistence.EntityTypeConfigurations;

public class AsparagusUserEatingConfiguration : IEntityTypeConfiguration<UserEating>
{
    public void Configure(EntityTypeBuilder<UserEating> builder)
    {
        builder.HasKey(ue => ue.Id);

        builder.HasOne(ue => ue.User)
            .WithMany(u => u.UserEatings)
            .HasForeignKey(ue => ue.UserId);

        builder.Property(ue => ue.EatingDate).IsRequired();
    }
}