using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoaring.SqlServerContext.EntityTypeConfiguration;

public class KompetenceTypeConfiguration : IEntityTypeConfiguration<KompetenceEntity>
{
    public void Configure(EntityTypeBuilder<KompetenceEntity> builder)
    {
        {
            builder.ToTable("Kompetence", "Unik");
            builder.HasKey(x => x.KompetenceId);
        }
    }
}