using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoaring.SqlServerContext.EntityTypeConfiguration;

public class ProjektTypeConfiguration : IEntityTypeConfiguration<ProjektEntity>
{
    public void Configure(EntityTypeBuilder<ProjektEntity> builder)
    {
        {
            builder.ToTable("Projekter", "Unik");
            builder.HasKey(x => x.ProjektId);
        }
    }
}