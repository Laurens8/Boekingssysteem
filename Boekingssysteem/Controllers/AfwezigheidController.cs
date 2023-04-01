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
            if (viewModel.Begindatum > viewModel.EindDatum)
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
                        EindDatum = viewModel.EindDatum
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
    }
}
