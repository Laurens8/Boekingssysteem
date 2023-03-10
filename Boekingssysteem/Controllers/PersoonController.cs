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
            var afwezigheden = _context.Afwezigheden.Include(x => x.Persoon);
            var personen = _context.Personen.Include(x => x.Afwezigheden);

            PersoonListViewModel plvm = new PersoonListViewModel();
            plvm.Afwezigheden = afwezigheden.ToList();
            plvm.Personen = personen.ToList();

            return View(plvm);
        }

        // Personeel/Create
        public IActionResult Create()
        {
            return View();
        }

        // Personeel/Edit
        //public async Task<IActionResult> Edit(string? id) 
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var persoon = await _context.Personen.FindAsync(id);
        //    if (persoon == null)
        //    {
        //        return NotFound();
        //    }

        //    EditPersoonViewModel viewModel = new EditPersoonViewModel()
        //    {
        //        Personeelnummer = persoon.Personeelnummer,
        //        Voornaam = persoon.Voornaam,
        //        Naam = persoon.Naam,
        //        Admin = persoon.Admin
        //    };

        //    return View(viewModel);
        //}

        public async Task<IActionResult> Edit(string id, EditPersoonViewModel viewModel)
        {
            if (id != viewModel.Personeelnummer)
            {
                return NotFound(viewModel);
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
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        // Personeel/Delete
        public async Task<IActionResult> Delete(string? id)
        {
            return View();

            //if (id == null) 
            //{
            //    return NotFound();
            //}

            //var persoon = await _context.Personen.FirstOrDefaultAsync(p => p.Personeelnummer == id);
            //if (persoon == null)
            //{
            //    return NotFound();
            //}

            //DeletePersoonViewModel viewModel = new DeletePersoonViewModel()
            //{
            //    Personeelnummer = persoon.Personeelnummer,
            //    Voornaam = persoon.Voornaam,
            //    Naam = persoon.Naam
            //};

            //return View(viewModel);
        }

        // POST: Klant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var persoon = await _context.Personen.FindAsync(id);
            _context.Personen.Remove(persoon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
