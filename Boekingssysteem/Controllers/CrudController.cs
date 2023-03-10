using Microsoft.AspNetCore.Mvc;

namespace Boekingssysteem.Controllers
{
    public class CrudController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GebruikerToevoegen()
        {
            return View("GebruikerToevoegen");
        }

        public IActionResult GebruikerAanpassen()
        {
            return View("GebruikerAanpassen");
        }

        public IActionResult GebruikerVerwijderen()
        {
            return View("GebruikerVerwijderen");
        }
    }
}
