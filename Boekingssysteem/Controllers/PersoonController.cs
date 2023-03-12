using Boekingssysteem.Data;
using Boekingssysteem.Models;
using Boekingssysteem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            return View(new EditPersoonViewModel());
        }

        [HttpPost]
        public IActionResult Aanpassen(EditPersoonViewModel vm)
        {
            string personeelsnummer = vm.Personeelnummer;
            
            return View();
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
    }
}
