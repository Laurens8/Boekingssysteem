using Boekingssysteem.Data;
using Boekingssysteem.Lib;
using Boekingssysteem.Models;
using Boekingssysteem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Boekingssysteem.Controllers
{
    public class PersoonController : Controller
    {
        private readonly BoekingssysteemContext _context;

        public PersoonController(BoekingssysteemContext context)
        {
            _context = context;
        }

        public ViewResult Index()
        {
            return View();
        }

        public IActionResult Toevoegen()
        {
            ViewBag.Visibility = "invisible";
            ViewBag.Functies = _context.Functies;
            ViewBag.Richtingen = _context.Richtingen;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Toevoegen(PersoonCRUDViewModel viewModel, string personeelnummer, int[] FunctieIDs, int[] RichtingIDs)
        {
            ViewBag.Functies = _context.Functies;
            ViewBag.Richtingen = _context.Richtingen;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(new Persoon()
                    {
                        Personeelnummer = viewModel.Personeelnummer,
                        Naam = viewModel.Naam,
                        Voornaam = viewModel.Voornaam,
                        Admin = viewModel.Admin
                    });
                    await _context.SaveChangesAsync();

                    foreach (int ID in RichtingIDs)
                    {
                        
                        _context.Add(new PersoonRichting()
                        {
                            Personeelnummer = personeelnummer,
                            RichtingID = ID
                        });
                        await _context.SaveChangesAsync();
                    }

                    foreach (int ID in FunctieIDs)
                    {
                        _context.Add(new PersoonFunctie()
                        {
                            Personeelnummer = personeelnummer,
                            FunctieID = ID
                        });
                        
                        //_context.PersoonFuncties.Add(persFunctie);
                        await _context.SaveChangesAsync();
                    }

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    Foutenlogboek.FoutLoggen(ex);
                    ViewBag.Class = "alert alert-danger mb-5";
                    ViewBag.Visibility = "visible";
                }
            }
            return View(viewModel);
        }

        public IActionResult Aanpassen()
        {
            ViewBag.Visibility = "invisible";
            ViewBag.Functies = _context.Functies;
            ViewBag.Richtingen = _context.Richtingen;

            return View();
        }

        [HttpPost]
        public IActionResult Aanpassen(string personeelnummer)
        {
            ViewBag.Visibility = "invisible";
            ViewBag.Functies = _context.Functies;
            ViewBag.Richtingen = _context.Richtingen;

            bool gevonden = false;
            var lijstPersonen = _context.Personen.ToList();

            foreach (var persoon in lijstPersonen)
            {
                if (persoon.Personeelnummer == personeelnummer)
                {
                    gevonden = true;
                }
            }

            try
            {
                if (gevonden)
                {
                    Persoon persoon = _context.Personen.Find(personeelnummer);
                    PersoonCRUDViewModel viewModel = new PersoonCRUDViewModel()
                    {
                        Personeelnummer = persoon.Personeelnummer,
                        Naam = persoon.Naam,
                        Voornaam = persoon.Voornaam,
                        Admin = persoon.Admin

                    };

                    return View(viewModel);
                }
                else
                {
                    ViewBag.Class = "alert alert-danger mb-5";
                    ViewBag.Visibility = "visible";

                    return View(nameof(Aanpassen));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost, ActionName("AanpassenDetail")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AanpassenDetail(string personeelnummer, PersoonCRUDViewModel viewModel, int[] FunctieIDs, int[] RichtingIDs)
        {
            ViewBag.Functies = _context.Functies;
            ViewBag.Richtingen = _context.Richtingen;

            if (personeelnummer == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Persoon persoon = new Persoon()
                    {
                        Personeelnummer = viewModel.Personeelnummer,
                        Voornaam = viewModel.Voornaam,
                        Naam = viewModel.Naam,
                        Admin = viewModel.Admin
                    };

                    _context.Update(persoon);
                    await _context.SaveChangesAsync();

                    //Bestaande PersoonFuncties & PersoonRichtingen verwijderen
                    foreach (var persf in _context.PersoonFuncties.ToList())
                    {
                        if (persf.Personeelnummer == personeelnummer)
                        {
                            _context.PersoonFuncties.Remove(persf);
                        }
                    }
                    foreach (var persr in _context.PersoonRichtingen.ToList())
                    {
                        if (persr.Personeelnummer == personeelnummer)
                        {
                            _context.PersoonRichtingen.Remove(persr);
                        }
                    }

                    //Nieuwe PersoonFuncties & PersoonRichtingen toevoegen
                    foreach (int ID in RichtingIDs)
                    {

                        _context.Add(new PersoonRichting()
                        {
                            Personeelnummer = personeelnummer,
                            RichtingID = ID
                        });
                        await _context.SaveChangesAsync();
                    }

                    foreach (int ID in FunctieIDs)
                    {
                        _context.Add(new PersoonFunctie()
                        {
                            Personeelnummer = personeelnummer,
                            FunctieID = ID
                        });

                        //_context.PersoonFuncties.Add(persFunctie);
                        await _context.SaveChangesAsync();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Personen.Any(e => e.Personeelnummer == viewModel.Personeelnummer))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Aanpassen");
            }

            return View("Aanpassen");
        }

        public IActionResult Verwijderen()
        {
            ViewBag.Enabled = "disabled";
            ViewBag.Visibility = "invisible";
            return View();
        }

        public IActionResult VerwijderenData(string personeelnummer)
        {
            bool gevonden = false;
            
            PersoonCRUDViewModel viewModel = new PersoonCRUDViewModel();
            var personen = _context.Personen.ToList();
            viewModel.Personen = personen;
            
            foreach (var persoon in personen)
            {
                if (persoon.Personeelnummer == personeelnummer)
                {
                    gevonden = true;
                }
            }

            if (gevonden)
            {
                try
                {
                    if (personeelnummer == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        Persoon persoon = _context.Personen.Find(personeelnummer);
                        ViewBag.naam = persoon.Naam;
                        ViewBag.voornaam = persoon.Voornaam;
                        ViewBag.personeelnummer = persoon.Personeelnummer;
                    }
                    return View("Verwijderen");
                }
                catch (Exception e)
                {

                    Foutenlogboek.FoutLoggen(e);
                }
                return View();
            }
            else
            {
                ViewBag.Class = "alert alert-danger mb-5";
                ViewBag.Visibility = "visible";

                return RedirectToAction("Verwijderen");
            }
        }

        public async Task<IActionResult> Delete(string? personeelnummer)
        {
            try
            {
                if (personeelnummer == null)
                {
                    return NotFound();
                }

                Persoon persoon = await _context.Personen.FirstOrDefaultAsync(k => k.Personeelnummer == personeelnummer);
                if (persoon == null)
                {
                    return NotFound();
                }

                PersoonCRUDViewModel vm = new PersoonCRUDViewModel()
                {
                    Personeelnummer = persoon.Personeelnummer,
                    Voornaam = persoon.Voornaam,
                    Naam = persoon.Naam
                };
                return View(vm);
            }
            catch (Exception e)
            {

                Foutenlogboek.FoutLoggen(e);
            }
            return View();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string? personeelnummer)
        {
            try
            {
                Persoon persoon = await _context.Personen.FindAsync(personeelnummer);
                _context.Personen.Remove(persoon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Verwijderen));
            }
            catch (Exception e)
            {

                Foutenlogboek.FoutLoggen(e);
            }
            return View();
        }

        public BoekingssysteemContext Get_context()
        {
            return _context;
        }
    }
}