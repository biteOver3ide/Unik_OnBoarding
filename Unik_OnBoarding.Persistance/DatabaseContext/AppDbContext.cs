using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Persistance.DatabaseContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<KundeEntity> Kunder { get; set; }
    public DbSet<ProjektEntity> Projektes { get; set; }
    public DbSet<MedarbejderEntity> Medarbejder { get; set; }
    public DbSet<KompetenceEntity> Kompetencerne { get; set; }
    public DbSet<OpgaverEntity> Opgaver { get; set; }
    public DbSet<BookingEntity> Bookinger { get; set; }

    // DATA SEEDING 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("Unik");

        var kundeid = Guid.Parse("{c5121b63-1bd8-4b99-9712-632603eeb167}");
        var kundeid2 = Guid.Parse("{f7709162-1bd8-4b99-9712-632603eeb167}");
        var p1 = Guid.Parse("{e7709162-a03f-4b4c-aeba-12573ef27676}");
        var p2 = Guid.Parse("{e660a592-adcc-4046-9247-be98fbb5891f}");
        modelBuilder.Entity<KundeEntity>().HasData(
            new KundeEntity
            {
                Kid = kundeid,
                Fornavn = "Søren",
                Efternavn = "Hansen",
                Firmanavn = "AAB",
                Cvr = 78452152,
                Email = "aab@vejle.dk",
                Adresse = "Vejlevej 123",
                Telefon = "41424344"
            });

        modelBuilder.Entity<KundeEntity>().HasData(
            new KundeEntity
            {
                Kid = kundeid2,
                Fornavn = "Jan",
                Efternavn = "Petersen",
                Firmanavn = "Bo-To",
                Cvr = 29189900,
                Email = "bo-to@vejle.dk",
                Adresse = "fynsvej 456",
                Telefon = "41785968"
            });

        modelBuilder.Entity<ProjektEntity>().HasData(
            new ProjektEntity
            {
                ProjektId = p1,
                KundeId = kundeid,
                ProjektTitle = "Onboaring Vejle AAB"
            },
            new ProjektEntity
            {
                ProjektId = p2,
                KundeId = kundeid,
                ProjektTitle = "Onboaring Kolding AAB"
            }
        );
    }
}