// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Unik_OnBoarding.Persistance.DatabaseContext;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221128083317_SeedingKundeProjekt")]
    partial class SeedingKundeProjekt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Unik_OnBoarding.Domain.Kunde", b =>
                {
                    b.Property<Guid>("Kid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefon")
                        .HasColumnType("int");

                    b.HasKey("Kid");

                    b.ToTable("Kunder");

                    b.HasData(
                        new
                        {
                            Kid = new Guid("c5121b63-1bd8-4b99-9712-632603eeb167"),
                            Email = "aab@vejle.dk",
                            Name = "AAB Vejle",
                            Telefon = 0
                        });
                });

            modelBuilder.Entity("Unik_OnBoarding.Domain.Projekt", b =>
                {
                    b.Property<Guid>("ProjektId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KundeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProjektTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjektId");

                    b.HasIndex("KundeId");

                    b.ToTable("Projektes");

                    b.HasData(
                        new
                        {
                            ProjektId = new Guid("e7709162-a03f-4b4c-aeba-12573ef27676"),
                            KundeId = new Guid("c5121b63-1bd8-4b99-9712-632603eeb167"),
                            ProjektTitle = "Onboaring Vejle AAB"
                        },
                        new
                        {
                            ProjektId = new Guid("e660a592-adcc-4046-9247-be98fbb5891f"),
                            KundeId = new Guid("c5121b63-1bd8-4b99-9712-632603eeb167"),
                            ProjektTitle = "Onboaring Kolding AAB"
                        });
                });

            modelBuilder.Entity("Unik_OnBoarding.Domain.Projekt", b =>
                {
                    b.HasOne("Unik_OnBoarding.Domain.Kunde", "Kunde")
                        .WithMany("Projekt")
                        .HasForeignKey("KundeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kunde");
                });

            modelBuilder.Entity("Unik_OnBoarding.Domain.Kunde", b =>
                {
                    b.Navigation("Projekt");
                });
#pragma warning restore 612, 618
        }
    }
}
