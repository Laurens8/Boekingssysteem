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

        public DbSet<Persoon> Personen { get; set; }
        public DbSet<Afwezigheid> Afwezigheden { get; set; }
        public DbSet<PersoonRichting> PersoonRichtingen { get; set; }
        public DbSet<Richting> Richtingen { get; set; }
        public DbSet<PersoonFunctie> PersoonFuncties { get; set; }
        public DbSet<Functie> Functie { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Boekingssysteem");

            //Tabellen aanmaken
            modelBuilder.Entity<Persoon>().ToTable("Persoon");
            modelBuilder.Entity<Afwezigheid>().ToTable("Afwezigheid");
            modelBuilder.Entity<PersoonRichting>().ToTable("PersoonRichting");
            modelBuilder.Entity<Richting>().ToTable("Richting");
            modelBuilder.Entity<PersoonFunctie>().ToTable("PersoonFunctie");
            modelBuilder.Entity<Functie>().ToTable("Functie");

            //Navigatietabellen
            /*Persoon kan meerdere afwezigheden hebben*/
            modelBuilder.Entity<Afwezigheid>().HasOne(p => p.Persoon).WithMany(a => a.Afwezigheden).HasForeignKey(p => p.Personeelnummer).IsRequired();

            /*Persoon kan meerdere afwezigheden hebben*/
            modelBuilder.Entity<PersoonRichting>().HasKey(pr => new { pr.RichtingID, pr.Personeelnummer });

            /*Persoon en Richting naar PersoonRichting*/
            modelBuilder.Entity<PersoonRichting>().HasOne(pr => pr.Persoon).WithMany(x => x.PersoonRichtingen).HasForeignKey(pr => pr.Personeelnummer).IsRequired();
            modelBuilder.Entity<PersoonRichting>().HasOne(pr => pr.Richting).WithMany(x => x.PersoonRichtingen).HasForeignKey(pr => pr.RichtingID).IsRequired();

            /*Persoon en Functie naar PersoonFunctie*/
            modelBuilder.Entity<PersoonFunctie>().HasOne(pf => pf.Persoon).WithMany(x => x.PersoonFuncties).HasForeignKey(pr => pr.Personeelnummer).IsRequired();
            modelBuilder.Entity<PersoonFunctie>().HasOne(pf => pf.Functie).WithMany(x => x.PersoonFuncties).HasForeignKey(pr => pr.FunctieID).IsRequired();

            //Tabellen vullen
            modelBuilder.Entity<Persoon>().HasData(new Persoon { Personeelnummer = "R0901658", Naam = "Mathieu", Voornaam = "Christophe", Admin = true, Aanwezig = true },
                                                         new Persoon { Personeelnummer = "R0901293", Naam = "De Wit", Voornaam = "Laurens", Admin = true, Aanwezig = true },
                                                         new Persoon { Personeelnummer = "R0658604", Naam = "Boeckx", Voornaam = "Lender", Admin = true, Aanwezig = true },
                                                         new Persoon { Personeelnummer = "R0123456", Naam = "Bellemans", Voornaam = "Johan", Admin = false, Aanwezig = true },
                                                         new Persoon { Personeelnummer = "R0123457", Naam = "Janssens", Voornaam = "Jan", Admin = true, Aanwezig = true });

            modelBuilder.Entity<Afwezigheid>().HasData(new Afwezigheid { AfwezigheidID = 1, Personeelnummer = "R0901658", Begindatum = new DateTime(2023, 04, 01), EindDatum = new DateTime(2023, 04, 30) });

            modelBuilder.Entity<Richting>().HasData(new Richting { RichtingID = 1, Naam = "Informatica" },
                                                    new Richting { RichtingID = 2, Naam = "Verpleegkunde" });

            modelBuilder.Entity<PersoonRichting>().HasData(new PersoonRichting { PersoonRichtingID = 1, Personeelnummer = "R0901658", RichtingID = 1 },
                                                           new PersoonRichting { PersoonRichtingID = 2, Personeelnummer = "R0658604", RichtingID = 1 },
                                                           new PersoonRichting { PersoonRichtingID = 3, Personeelnummer = "R0901293", RichtingID = 1 },
                                                           new PersoonRichting { PersoonRichtingID = 4, Personeelnummer = "R0123456", RichtingID = 2 });

            modelBuilder.Entity<Functie>().HasData(new Functie { FunctieID = 1, Naam = "Leerling" },
                                                    new Functie { FunctieID = 2, Naam = "Administratief personeel" },
                                                    new Functie { FunctieID = 3, Naam = "Leerkracht" });

            modelBuilder.Entity<PersoonFunctie>().HasData(new PersoonFunctie { PersoonFunctieID = 1, Personeelnummer = "R0901658", FunctieID = 1 },
                                                            new PersoonFunctie { PersoonFunctieID = 2, Personeelnummer = "R0658604", FunctieID = 1 },
                                                            new PersoonFunctie { PersoonFunctieID = 3, Personeelnummer = "R0901293", FunctieID = 1 },
                                                            new PersoonFunctie { PersoonFunctieID = 5, Personeelnummer = "R0123457", FunctieID = 2 },
                                                            new PersoonFunctie { PersoonFunctieID = 4, Personeelnummer = "R0123456", FunctieID = 3 });
        }
    }
}
