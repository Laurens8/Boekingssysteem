using Boekingssysteem.Data;
using Boekingssysteem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Boekingssysteem.Controllers
{
    public class StatusController : Controller
    {

        private readonly BoekingssysteemContext _context;

        //public IActionResult Index()
        //{
        //    PersoonViewModel viewModel = new PersoonViewModel();
        //    viewModel.Personen = _context.Personen.ToList();
        //    return View(viewModel);
        //}

        public StatusController(BoekingssysteemContext context)
        {
            _context = context;
        }

        public ViewResult Index()
        {
            var persoonrichtingen = _context.PersoonRichtingen.Include(x => x.Persoon).Include(z => z.Richting);
            var persoonfuncties = _context.PersoonFuncties.Include(x => x.Persoon).Include(z => z.Functie);
            var personen = _context.Personen.ToList();

            PersoonListViewModel viewModel = new PersoonListViewModel();
            viewModel.Personen = personen;
            viewModel.PersoonRichtingen = persoonrichtingen.ToList();
            viewModel.PersoonFuncties = persoonfuncties.ToList();

            return View(viewModel);
        }
    }
}
