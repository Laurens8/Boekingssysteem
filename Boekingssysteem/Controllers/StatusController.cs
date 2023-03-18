using Boekingssysteem.Data;
using Boekingssysteem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

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
        public async Task<IActionResult> StatusAanpassen(EditStatusViewModel vm)
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
                EditStatusViewModel viewModel = new EditStatusViewModel()
                {
                    Aanwezig = true
                };
                return View(viewModel);
            }
            else if(persoon.Aanwezig == true)
            {
                EditStatusViewModel viewModel = new EditStatusViewModel()
                {
                    Aanwezig = false
                };
                return View(viewModel);
            }
            else
            {
                EditStatusViewModel viewModel = new EditStatusViewModel()
                {
                    Aanwezig = true
                };
                return View(viewModel);
            }

            
        }
    }
}
