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

namespace Boekingssysteem.Controllers
{
    public class PersoonController : Controller
    {
        private readonly BoekingssysteemContext _context;

        public PersoonController(BoekingssysteemContext context)
        {
            _context = context;
        }

        // PersoonRichting tonen met Persoon en Richting
        public ViewResult Index()
        {
            return View();
        }

        public IActionResult Toevoegen()
        {
            var persoonfuncties = _context.PersoonFuncties.Include(x => x.Persoon);

            return View();
        }

        [HttpPut]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Toevoegen(CreatePersoonViewModel viewModel) 
        {
            try
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
            catch (Exception e)
            {

                Foutenlogboek.FoutLoggen(e);
            }
            return View(viewModel);
        }

        public IActionResult Aanpassen()
        {
            return View(new EditPersoonViewModel());
        }

        [HttpPut]
        public async Task<IActionResult> Aanpassen(EditPersoonViewModel vm)
        {
            try
            {
                string personeelsnummer = vm.Personeelnummer;

                if (personeelsnummer == null)
                {
                    return NotFound();
                }

                var persoon = await _context.Personen.FindAsync(personeelsnummer);
                if (persoon == null)
                {
                    return NotFound();
                }

                EditPersoonViewModel viewModel = new EditPersoonViewModel()
                {
                    Personeelnummer = persoon.Personeelnummer,
                    Voornaam = persoon.Voornaam,
                    Naam = persoon.Naam,
                    Admin = persoon.Admin
                };

                return View(viewModel);
            }
            catch (Exception e)
            {
                Foutenlogboek.FoutLoggen(e);
            }
            return View(vm);
        }

        [HttpPut]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AanpassenViaID(string id, EditPersoonViewModel vm)
        {
            try
            {
                if (id == vm.Personeelnummer)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        Persoon persoon = new Persoon()
                        {
                            Personeelnummer = vm.Personeelnummer,
                            Voornaam = vm.Voornaam,
                            Naam = vm.Naam,
                            Admin = vm.Admin
                        };

                        _context.Update(persoon);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!_context.Personen.Any(p => p.Personeelnummer == vm.Personeelnummer))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Aanpassen));
                }
                return View(vm);
            }
            catch (Exception e)
            {
               Foutenlogboek.FoutLoggen(e);
            }
           return View(vm);
        }

        public BoekingssysteemContext Get_context()
        {
            return _context;
        }

        //public async Task<IActionResult> Search(EditPersoonViewModel viewModel)
        //{
        //    var personen = _context.Personen.ToList();

        //    if (!string.IsNullOrWhiteSpace(viewModel.PersoonSearch))
        //    {
        //        var persoonID = personen.Where(p => p.Personeelnummer == viewModel.Personeelnummer);
        //        Persoon persoon = new Persoon();
        //        //viewModel.Persoon = (Persoon)personen.Where(p => p.Personeelnummer.Equals(viewModel.PersoonSearch));
        //        string id = persoon.Personeelnummer;

        //        //Persoon persoon = await _context.Personen.FindAsync(id);

        //        EditPersoonViewModel vm = new EditPersoonViewModel()
        //        {
        //            Personeelnummer = persoon.Personeelnummer,
        //            Naam = persoon.Naam,
        //            Voornaam = persoon.Voornaam,
        //            Admin = persoon.Admin
        //        };

        //        return View(vm);


        //        //return View(AanpassenDetail(id));
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //public async Task<IActionResult> AanpassenDetail(string id) 
        //{

        //}

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
    }
}
