using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoaring.SqlServerContext.EntityTypeConfiguration;

public class OpgaverTypeConfiguration : IEntityTypeConfiguration<OpgaverEntity>
{
    public void Configure(EntityTypeBuilder<OpgaverEntity> builder)
    {
        {
            builder.ToTable("Opgaver", "Unik");
            builder.HasKey(x => x.OpgaveId);
        }
    }
}