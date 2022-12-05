using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoaring.SqlServerContext.EntityTypeConfiguration;

public class KundeTypeConfiguration : IEntityTypeConfiguration<KundeEntity>
{
    public void Configure(EntityTypeBuilder<KundeEntity> builder)
    {
        {
            builder.ToTable("Kunde", "Unik");
            builder.HasKey(x => x.Kid);
        }
    }
}