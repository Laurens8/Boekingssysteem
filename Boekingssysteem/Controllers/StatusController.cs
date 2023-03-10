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


        // GET: Personeel
        public async Task<IActionResult> Index()
        {
            PersoonListViewModel viewModel = new PersoonListViewModel();
            viewModel.Personen = await _context.Personen.ToListAsync();

            return View(viewModel);
        }
    }
}
