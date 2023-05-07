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
        string persnr = "";

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
            var personen = _context.Personen.ToList();
            AfwezigheidCRUDViewModel plvm = new AfwezigheidCRUDViewModel();
            plvm.Personen = personen;

            return View(plvm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Toevoegen(AfwezigheidCRUDViewModel viewModel)
        {
            ViewBag.Visibility = "invisible";
            DateTime nu = DateTime.Now;
            var afwezigheden = _context.Afwezigheden.Where(a => a.Personeelnummer == viewModel.Personeelnummer);

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
            foreach (var afwezigheid in afwezigheden)
            {
                if (viewModel.Begindatum > afwezigheid.Begindatum && viewModel.Einddatum < afwezigheid.Einddatum)
                {
                    ViewBag.Message = "Er is deze periode al een afwezigheid geregistreerd!";
                    ViewBag.Class = "alert alert-danger mb-5";
                    ViewBag.Visibility = "visible";
                    return View(nameof(Toevoegen));
                }
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
            var personen = _context.Personen.ToList();
            AfwezigheidCRUDViewModel plvm = new AfwezigheidCRUDViewModel();
            plvm.Personen = personen;
            ViewBag.Afwezigheden = "";
            return View(plvm);            
        }

        [HttpPost]
        public IActionResult Aanpassen(AfwezigheidCRUDViewModel viewModel)
        {
            Persoon persoon = _context.Personen.Find(viewModel.Personeelnummer);
            ViewBag.Afwezigheden = _context.Afwezigheden.Where(a => a.Personeelnummer == viewModel.Personeelnummer).OrderBy(a => a.Begindatum);

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
                return RedirectToAction(nameof(Aanpassen));
            }

            return RedirectToAction(nameof(Aanpassen));
        }

        public async Task<IActionResult> Verwijderen(string personeelnummer, int id)
        {
            Afwezigheid afwezigheid = _context.Afwezigheden.Where(d => d.AfwezigheidID == id).FirstOrDefault();
            if (afwezigheid != null)
            {
                AfwezigheidCRUDViewModel vm = new AfwezigheidCRUDViewModel()
                {
                    AfwezigheidID = id
                };
            }

            _context.Afwezigheden.Remove(afwezigheid);
            await _context.SaveChangesAsync();

            //ViewBag.Message = "Afwezigheid succesvol verwijderd!";
            //ViewBag.Class = "alert alert-succes mb-5";
            //ViewBag.Visibility = "visible";

            return RedirectToAction(nameof(Index));
        }
    }
}
