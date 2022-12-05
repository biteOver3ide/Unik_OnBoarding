using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoaring.SqlServerContext.EntityTypeConfiguration;

public class BookingTypeConfiguration : IEntityTypeConfiguration<BookingEntity>
{
    public void Configure(EntityTypeBuilder<BookingEntity> builder)
    {
        {
            builder.ToTable("Booking", "Unik");
            builder.HasKey(x => x.BookId);
        }
    }
}