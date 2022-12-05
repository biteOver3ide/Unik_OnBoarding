using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Domain.Model;
using Unik_OnBoaring.SqlServerContext.EntityTypeConfiguration;

namespace Unik_OnBoaring.SqlServerContext;

public class Unik_OnBoardingContext : DbContext
{
    public Unik_OnBoardingContext(DbContextOptions<Unik_OnBoardingContext> options) : base(options)
    {
    }

    public DbSet<BookingEntity> Bookinger { get; set; }
    public DbSet<KompetenceEntity> Kompetencer { get; set; }
    public DbSet<KundeEntity> Kunder { get; set; }
    public DbSet<MedarbejderEntity> Medarbejder { get; set; }
    public DbSet<OpgaverEntity> Opgaver { get; set; }
    public DbSet<ProjektEntity> Projekter { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new BookingTypeConfiguration());
        builder.ApplyConfiguration(new KundeTypeConfiguration());
        builder.ApplyConfiguration(new KompetenceTypeConfiguration());
        builder.ApplyConfiguration(new MedarbejderTypeConfiguration());
        builder.ApplyConfiguration(new OpgaverTypeConfiguration());
        builder.ApplyConfiguration(new ProjektTypeConfiguration());
    }
}