using Boekingssysteem.Data;
using Boekingssysteem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Boekingssysteem.Controllers
{
    public class AfwezigheidController : Controller
    {
        private readonly BoekingssysteemContext _context;

        public AfwezigheidController(BoekingssysteemContext context)
        {
            _context = context;
        }

        //Dit is voor Persoon met Afwezigheid te linken
        public ViewResult PersoonAfwezigheden()
        {
            var afwezigheden = _context.Afwezigheden.Include(x => x.Persoon);
            var personen = _context.Personen.Include(x => x.Afwezigheden);

            PersoonListViewModel plvm = new PersoonListViewModel();
            plvm.Afwezigheden = afwezigheden.ToList();
            plvm.Personen = personen.ToList();

            return View(plvm);
        }
    }
}
