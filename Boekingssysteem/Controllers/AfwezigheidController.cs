using Boekingssysteem.Data;
using Boekingssysteem.Lib;
using Boekingssysteem.Models;
using Boekingssysteem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Boekingssysteem.Controllers
{
    public class AfwezigheidController : Controller
    {
        private readonly BoekingssysteemContext _context;

        public AfwezigheidController(BoekingssysteemContext context)
        {
            _context = context;
        }
        public ViewResult Index()
        {
            return View();
        }

        public IActionResult Toevoegen()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Toevoegen(AfwezigheidCRUDViewModel viewModel)
        {
            ViewBag.Visibility = "invisible";
            DateTime nu = DateTime.Now;

            if (nu > viewModel.Begindatum)
            {
                ViewBag.Message = "Begindatum kan niet in het verleden liggen!";
                ViewBag.Class = "alert alert-danger mb-5";
                ViewBag.Visibility = "visible";
                return View(nameof(Toevoegen));
            }
            if (viewModel.Begindatum > viewModel.Einddatum)
            {
                ViewBag.Message = "Begindatum moet voor de einddatum liggen!";
                ViewBag.Class = "alert alert-danger mb-5";
                ViewBag.Visibility = "visible";
                return View(nameof(Toevoegen));
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(new Afwezigheid()
                    {
                        Personeelnummer = viewModel.Personeelnummer,
                        Begindatum = viewModel.Begindatum,
                        Einddatum = viewModel.Einddatum
                    });

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    Foutenlogboek.FoutLoggen(ex);
                }

            }
            return View(Toevoegen());
        }

        public IActionResult Aanpassen()
        {
            ViewBag.Afwezigheden = "";
            return View();
        }

        [HttpPost]
        public IActionResult Aanpassen(string personeelnummer)
        {
            Persoon persoon = _context.Personen.Find(personeelnummer);
            ViewBag.Afwezigheden = _context.Afwezigheden.Where(a => a.Personeelnummer == personeelnummer);

            return View();
        }

        public async Task<IActionResult> AanpassenDetail(int id) 
        {
            if (id == null)
            {
                return NotFound();
            }

            var afwezigheid = await _context.Afwezigheden.FindAsync(id);
            if (afwezigheid == null)
            {
                return NotFound();
            }

            AfwezigheidCRUDViewModel viewModel = new AfwezigheidCRUDViewModel()
            {
                AfwezigheidID = afwezigheid.AfwezigheidID,
                Begindatum = afwezigheid.Begindatum,
                Einddatum = afwezigheid.Einddatum,
                Personeelnummer = afwezigheid.Personeelnummer
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AanpassenDetail(int id, AfwezigheidCRUDViewModel viewModel)
        {
            string personeelnummer;
            
            if (id != viewModel.AfwezigheidID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Afwezigheid afwezigheid = new Afwezigheid()
                    {
                        AfwezigheidID = viewModel.AfwezigheidID,
                        Begindatum = viewModel.Begindatum,
                        Einddatum = viewModel.Einddatum,
                        Personeelnummer = viewModel.Personeelnummer
                    };

                    _context.Update(afwezigheid);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Afwezigheden.Any(e => e.AfwezigheidID == viewModel.AfwezigheidID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return View(RedirectToAction("Aanpassen(personeelnummer)"));
            }

            return View(RedirectToAction("Aanpassen"));
        }

        public IActionResult Verwijderen(string personeelnummer, int id)
        {
            
            
            return View(Aanpassen(personeelnummer));
        }
    }
}
