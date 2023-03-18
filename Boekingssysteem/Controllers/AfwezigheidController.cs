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

            AfwezigheidListViewModel alvm = new AfwezigheidListViewModel();
            alvm.Afwezigheden = afwezigheden.ToList();
            alvm.Personen = personen.ToList();

            return View(alvm);
        }
    }
}
