using Boekingssysteem.Data;
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
            var persoonfuncties = _context.PersoonFuncties.Include(x => x.Persoon);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Toevoegen(CreatePersoonViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(new Persoon()
                {
                    Personeelnummer = viewModel.Personeelnummer,
                    Naam = viewModel.Naam,
                    Voornaam = viewModel.Voornaam,
                    Admin = viewModel.Admin
                });
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        public IActionResult Aanpassen()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Aanpassen(string personeelnummer)
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
                    EditPersoonViewModel viewModel = new EditPersoonViewModel()
                    {
                        Personeelnummer = persoon.Personeelnummer,
                        Naam = persoon.Naam,
                        Voornaam = persoon.Voornaam,
                        Admin = persoon.Admin
                    };

                    return View(viewModel);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost, ActionName("AanpassenViaID")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AanpassenViaID(string personeelnummer, EditPersoonViewModel viewModel)
        {
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

                ViewBag.JavaScriptFunction = string.Format("MeldingSucces('{0}');", personeelnummer);
                return RedirectToAction("Aanpassen");
            }

            return View("Aanpassen");
        }

        public IActionResult Verwijderen()
        {
            return View();
        }

        public IActionResult VerwijderenData(string personeelnummer)
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
            catch (Exception)
            {

                throw;
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

                DeletePersoonViewModel vm = new DeletePersoonViewModel()
                {
                    Personeelnummer = persoon.Personeelnummer,
                    Voornaam = persoon.Voornaam,
                    Naam = persoon.Naam
                };
                return View(vm);
            }
            catch (Exception)
            {

                throw;
            }

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
            catch (Exception)
            {

                throw;
            }

        }

        public BoekingssysteemContext Get_context()
        {
            return _context;
        }
    }

}