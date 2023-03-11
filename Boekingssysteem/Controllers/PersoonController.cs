using Boekingssysteem.Data;
using Boekingssysteem.Models;
using Boekingssysteem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult Verwijderen()
        {
            return View();
        }
    }
}
