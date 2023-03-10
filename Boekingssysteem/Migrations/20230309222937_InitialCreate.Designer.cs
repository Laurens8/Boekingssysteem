﻿// <auto-generated />
using System;
using Boekingssysteem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Boekingssysteem.Migrations
{
    [DbContext(typeof(BoekingssysteemContext))]
    [Migration("20230309222937_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Boekingssysteem")
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Boekingssysteem.Models.Afwezigheid", b =>
                {
                    b.Property<int>("AfwezigheidID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Begindatum")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EindDatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersoonID")
                        .HasColumnType("int");

                    b.HasKey("AfwezigheidID");

                    b.ToTable("Afwezigheid");

                    b.HasData(
                        new
                        {
                            AfwezigheidID = 1,
                            Begindatum = new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EindDatum = new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersoonID = 1
                        });
                });

            modelBuilder.Entity("Boekingssysteem.Models.Persoon", b =>
                {
                    b.Property<int>("PersoonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Personeelnummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersoonID");

                    b.ToTable("Persoon");

                    b.HasData(
                        new
                        {
                            PersoonID = 1,
                            Admin = true,
                            Naam = "Mathieu",
                            Personeelnummer = "R0901658",
                            Voornaam = "Christophe"
                        },
                        new
                        {
                            PersoonID = 2,
                            Admin = true,
                            Naam = "De Wit",
                            Personeelnummer = "R0658604",
                            Voornaam = "Laurens"
                        },
                        new
                        {
                            PersoonID = 3,
                            Admin = true,
                            Naam = "Boeckx",
                            Personeelnummer = "R0658604",
                            Voornaam = "Lender"
                        });
                });

            modelBuilder.Entity("Boekingssysteem.Models.PersoonVakStatus", b =>
                {
                    b.Property<int>("PersoonVakStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersoonID")
                        .HasColumnType("int");

                    b.Property<int>("VakID")
                        .HasColumnType("int");

                    b.HasKey("PersoonVakStatusID");

                    b.ToTable("PersoonVakStatus");

                    b.HasData(
                        new
                        {
                            PersoonVakStatusID = 1,
                            PersoonID = 1,
                            VakID = 1
                        });
                });

            modelBuilder.Entity("Boekingssysteem.Models.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Aanwezig")
                        .HasColumnType("bit");

                    b.Property<bool?>("Onbekend")
                        .HasColumnType("bit");

                    b.Property<int>("PersoonID")
                        .HasColumnType("int");

                    b.HasKey("StatusID");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            StatusID = 1,
                            Aanwezig = true,
                            Onbekend = false,
                            PersoonID = 1
                        });
                });

            modelBuilder.Entity("Boekingssysteem.Models.Vak", b =>
                {
                    b.Property<int>("VakID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VakID");

                    b.ToTable("Vak");

                    b.HasData(
                        new
                        {
                            VakID = 1,
                            Naam = "Informatica"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
