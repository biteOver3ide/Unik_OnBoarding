using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoaring.SqlServerContext.EntityTypeConfiguration;

public class MedarbejderTypeConfiguration : IEntityTypeConfiguration<MedarbejderEntity>
{
    public void Configure(EntityTypeBuilder<MedarbejderEntity> builder)
    {
        {
            builder.ToTable("Medarbejder", "Unik");
            builder.HasKey(x => x.MedarbejderId);
        }
    }
}