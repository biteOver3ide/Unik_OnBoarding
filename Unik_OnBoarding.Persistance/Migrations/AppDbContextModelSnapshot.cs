﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Unik_OnBoarding.Persistance.DbContext;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Unik_OnBoarding.Domain.Model.BookingEntity", b =>
                {
                    b.Property<Guid>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MedarbejderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OpgaveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProjektId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BookId");

                    b.HasIndex("MedarbejderId");

                    b.HasIndex("OpgaveId");

                    b.HasIndex("ProjektId");

                    b.ToTable("Bookinger");
                });

            modelBuilder.Entity("Unik_OnBoarding.Domain.Model.KompetenceEntity", b =>
                {
                    b.Property<Guid>("KompetenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Beskrivelse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KompetenceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("KompetenceId");

                    b.ToTable("Kompetencerne");
                });

            modelBuilder.Entity("Unik_OnBoarding.Domain.Model.KundeEntity", b =>
                {
                    b.Property<Guid>("Kid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cvr")
                        .HasColumnType("int");

                    b.Property<string>("Efternavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firmanavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fornavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Kid");

                    b.ToTable("Kunder");

                    b.HasData(
                        new
                        {
                            Kid = new Guid("c5121b63-1bd8-4b99-9712-632603eeb167"),
                            Adresse = "Vejlevej 123",
                            Cvr = 78452152,
                            Efternavn = "Hansen",
                            Email = "aab@vejle.dk",
                            Firmanavn = "AAB",
                            Fornavn = "Søren",
                            Telefon = "41424344"
                        },
                        new
                        {
                            Kid = new Guid("f7709162-1bd8-4b99-9712-632603eeb167"),
                            Adresse = "fynsvej 456",
                            Cvr = 29189900,
                            Efternavn = "Petersen",
                            Email = "bo-to@vejle.dk",
                            Firmanavn = "Bo-To",
                            Fornavn = "Jan",
                            Telefon = "41785968"
                        });
                });

            modelBuilder.Entity("Unik_OnBoarding.Domain.Model.MedarbejderEntity", b =>
                {
                    b.Property<Guid>("MedarbejderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Efternavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fornavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedarbejderId");

                    b.ToTable("Medarbejder");
                });

            modelBuilder.Entity("Unik_OnBoarding.Domain.Model.OpgaverEntity", b =>
                {
                    b.Property<Guid>("OpgaveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Beskrivelse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpgaveName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("OpgaveId");

                    b.ToTable("Opgaver");
                });

            modelBuilder.Entity("Unik_OnBoarding.Domain.Model.ProjektEntity", b =>
                {
                    b.Property<Guid>("ProjektId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KundeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProjektTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

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

            modelBuilder.Entity("Unik_OnBoarding.Domain.Model.BookingEntity", b =>
                {
                    b.HasOne("Unik_OnBoarding.Domain.Model.MedarbejderEntity", "Medarbejder")
                        .WithMany()
                        .HasForeignKey("MedarbejderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unik_OnBoarding.Domain.Model.OpgaverEntity", "Opgave")
                        .WithMany()
                        .HasForeignKey("OpgaveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unik_OnBoarding.Domain.Model.ProjektEntity", "Projekt")
                        .WithMany()
                        .HasForeignKey("ProjektId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medarbejder");

                    b.Navigation("Opgave");

                    b.Navigation("Projekt");
                });

            modelBuilder.Entity("Unik_OnBoarding.Domain.Model.ProjektEntity", b =>
                {
                    b.HasOne("Unik_OnBoarding.Domain.Model.KundeEntity", "Kunde")
                        .WithMany("Projekt")
                        .HasForeignKey("KundeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kunde");
                });

            modelBuilder.Entity("Unik_OnBoarding.Domain.Model.KundeEntity", b =>
                {
                    b.Navigation("Projekt");
                });
#pragma warning restore 612, 618
        }
    }
}
