using Boekingssysteem.Data;
using Boekingssysteem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Boekingssysteem.Models;
using Boekingssysteem.Lib;
using System;

namespace Boekingssysteem.Controllers
{
    public class StatusController : Controller
    {
        private readonly BoekingssysteemContext _context;
        private readonly ILogger<StatusController> _logger;

        public StatusController(ILogger<StatusController> logger, BoekingssysteemContext context)
        {
            _context = context;
            _logger = logger;
        }

        public ViewResult Index()
        {
            var personen = _context.Personen.ToList();
            var persoonrichtingen = _context.PersoonRichtingen.Include(x => x.Persoon).Include(z => z.Richting);
            var persoonfuncties = _context.PersoonFuncties.Include(x => x.Persoon).Include(z => z.Functie);
            PersoonListViewModel plvm = new PersoonListViewModel();
            plvm.Personen = personen;
            plvm.PersoonRichtingen = persoonrichtingen.ToList();
            plvm.PersoonFuncties = persoonfuncties.ToList();

            return View(plvm);
        }

        public IActionResult StatusIndividueel()
        {
            return View();
        }

        public async Task<IActionResult> StatusAanpassen(EditPersoonViewModel vm)
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

            if (persoon.Aanwezig == null)
            {
                EditPersoonViewModel viewModel = new EditPersoonViewModel()
                {
                    Aanwezig = true
                };
                return View(viewModel);
            }
            else if (persoon.Aanwezig == true)
            {
                EditPersoonViewModel viewModel = new EditPersoonViewModel()
                {
                    Aanwezig = false
                };
                return View(viewModel);
            }
            else
            {
                EditPersoonViewModel viewModel = new EditPersoonViewModel()
                {
                    Aanwezig = true
                };
                return View(viewModel);
            }

            return View();
        }

        public IActionResult StatusData(string personeelnummer)
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
                    ViewBag.Aanwezig = persoon.Aanwezig;
                }
                return View("StatusIndividueel");
            }
            catch (Exception e)
            {

                Foutenlogboek.FoutLoggen(e);
            }
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
                        Admin = persoon.Admin,
                        Aanwezig = persoon.Aanwezig
                    };

                    return View(viewModel);
                }
            }
            catch (Exception e)
            {
                Foutenlogboek.FoutLoggen(e);
            }
            return View();
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
                        Admin = viewModel.Admin,
                        Aanwezig = viewModel.Aanwezig
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
    }
}
