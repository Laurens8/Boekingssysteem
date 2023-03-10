using System.Collections.Generic;
using System.Reflection.Emit;
using System;
using Microsoft.EntityFrameworkCore;
using Boekingssysteem.Models;

namespace Boekingssysteem.Data
{
    public class BoekingssysteemContext : DbContext
    {
        public BoekingssysteemContext(DbContextOptions<BoekingssysteemContext> options) : base(options) { }

        public DbSet<Afwezigheid> Afwezigheden { get; set; }
        public DbSet<Persoon> Personen { get; set; }
        public DbSet<PersoonVakStatus> PersoonVakkenStatussen { get; set; }
        public DbSet<Status> Statussen { get; set; }
        public DbSet<Vak> Vakken { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Boekingssysteem");

            modelBuilder.Entity<Afwezigheid>().ToTable("Afwezigheid");
            modelBuilder.Entity<Persoon>().ToTable("Persoon");
            modelBuilder.Entity<PersoonVakStatus>().ToTable("PersoonVakStatus");
            modelBuilder.Entity<Status>().ToTable("Status");
            modelBuilder.Entity<Vak>().ToTable("Vak");

            modelBuilder.Entity<Afwezigheid>().HasData(new Afwezigheid { AfwezigheidID = 1, PersoonID = 1, Begindatum = new DateTime(2023, 08, 01), EindDatum = new DateTime(2023, 08, 31) });
            modelBuilder.Entity<Persoon>().HasData(new Persoon { PersoonID = 1, Naam = "Mathieu", Voornaam = "Christophe", Admin = true, Personeelnummer = "R0901658" },
                                                         new Persoon { PersoonID = 2, Naam = "De Wit", Voornaam = "Laurens", Admin = true, Personeelnummer = "R0658604" },
                                                         new Persoon { PersoonID = 3, Naam = "Boeckx", Voornaam = "Lender", Admin = true, Personeelnummer = "R0658604" });

            modelBuilder.Entity<Status>().HasData(new Status { StatusID = 1, PersoonID = 1, Aanwezig = true, Onbekend = false });

            modelBuilder.Entity<Vak>().HasData(new Vak { VakID = 1, Naam = "Informatica" });

            modelBuilder.Entity<PersoonVakStatus>().HasData(new PersoonVakStatus { PersoonVakStatusID = 1, PersoonID = 1, VakID = 1 });


        }
    }
}
