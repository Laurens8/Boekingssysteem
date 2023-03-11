using Boekingssysteem.Lib;
using Boekingssysteem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;

namespace Boekingssysteem.Data
{
    public static class BoekingssysteemIntialiser
    {
        public static void MaakPersoonDetails(BoekingssysteemContext context) 
        {
            BoekingssysteemContext _context = context;

            if (_context.Personen.Any())
            {
                return;
            }

            var personen = new List<Persoon>{
                new Persoon { Personeelnummer = "R0901658", Naam = "Mathieu", Voornaam = "Christophe", Admin = true, Aanwezig = true },
                new Persoon { Personeelnummer = "R0901293", Naam = "De Wit", Voornaam = "Laurens", Admin = true, Aanwezig = true },
                new Persoon { Personeelnummer = "R0658604", Naam = "Boeckx", Voornaam = "Lender", Admin = true, Aanwezig = true },
                new Persoon { Personeelnummer = "R0123456", Naam = "Bellemans", Voornaam = "Johan", Admin = false, Aanwezig = true },
                new Persoon { Personeelnummer = "R0123457", Naam = "Janssens", Voornaam = "Jan", Admin = true, Aanwezig = true }
            };

            var richtingen = new List<Richting>{
                new Richting { RichtingID = 1, Naam = "Informatica" },
                new Richting { RichtingID = 2, Naam = "Verpleegkunde" }
            };

            var functies = new List<Functie>{
                new Functie { FunctieID = 1, Naam = "Leerling" },
                new Functie { FunctieID = 2, Naam = "Administratief personeel" },
                new Functie { FunctieID = 3, Naam = "Leerkracht" }
            };

            personen.ForEach(p => _context.Personen.Add(p));
            richtingen.ForEach(r => _context.Richtingen.Add(r));
            functies.ForEach(f => _context.Functies.Add(f));

            try
            {
                _context.SaveChanges();

                //Associatie-entiteiten
                //PersoonFunctie
                var persoonfunctieKeys = new List<PersoonFunctie>{
                    new PersoonFunctie { PersoonFunctieID = 1, Personeelnummer = personen[0].Personeelnummer, FunctieID = functies[0].FunctieID },
                    new PersoonFunctie { PersoonFunctieID = 2, Personeelnummer = personen[2].Personeelnummer, FunctieID = functies[0].FunctieID },
                    new PersoonFunctie { PersoonFunctieID = 3, Personeelnummer = personen[1].Personeelnummer, FunctieID = functies[0].FunctieID },
                    new PersoonFunctie { PersoonFunctieID = 5, Personeelnummer = personen[4].Personeelnummer, FunctieID = functies[1].FunctieID },
                    new PersoonFunctie { PersoonFunctieID = 4, Personeelnummer = personen[3].Personeelnummer, FunctieID = functies[2].FunctieID }
                };
                persoonfunctieKeys.ForEach(pfk => _context.PersoonFuncties.Add(pfk));

                //PersoonRichting
                var persoonrichtingKeys = new List<PersoonRichting>
                {
                    new PersoonRichting { PersoonRichtingID = 1, Personeelnummer = personen[0].Personeelnummer, RichtingID = richtingen[0].RichtingID },
                    new PersoonRichting { PersoonRichtingID = 2, Personeelnummer = personen[2].Personeelnummer, RichtingID = richtingen[0].RichtingID },
                    new PersoonRichting { PersoonRichtingID = 3, Personeelnummer = personen[1].Personeelnummer, RichtingID = richtingen[0].RichtingID },
                    new PersoonRichting { PersoonRichtingID = 4, Personeelnummer = personen[3].Personeelnummer, RichtingID = richtingen[1].RichtingID }
                };
                persoonrichtingKeys.ForEach(prk => _context.PersoonRichtingen.Add(prk));

                //Afwezigheden
                var afwezigheden = new List<Afwezigheid>{
                    new Afwezigheid { AfwezigheidID = 1, Personeelnummer = personen[0].Personeelnummer, Begindatum = new DateTime(2023, 04, 01), EindDatum = new DateTime(2023, 04, 30) }
                };
                afwezigheden.ForEach(a => _context.Afwezigheden.Add(a));

                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                Foutenlogboek.FoutLoggen(e);
                if (e.InnerException != null)
                {
                    var msg = e.InnerException.Message.ToString();
                    Foutenlogboek.RegInner(msg);
                }
            }
            catch (Exception e) 
            {
                Foutenlogboek.FoutLoggen(e);
                if (e.InnerException != null)
                {
                    var msg = e.InnerException.Message.ToString();
                    Foutenlogboek.RegInner(msg);
                }
            }
        }
    }
}
