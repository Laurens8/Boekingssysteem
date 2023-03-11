using Boekingssysteem.Data;
using Microsoft.AspNetCore.Mvc;

namespace Boekingssysteem.Controllers
{
    public class TVController : Controller
    {
        private readonly BoekingssysteemContext _context;

        public TVController(BoekingssysteemContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
