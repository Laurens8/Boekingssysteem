
using Boekingssysteem.Data;
using Boekingssysteem.Lib;
using Boekingssysteem.Models;
using Boekingssysteem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Boekingssysteem.Controllers
{
    public class HomeController : Controller
    {
        private readonly BoekingssysteemContext _context;
        
        public HomeController(BoekingssysteemContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AdminView()
        {
            return View();
        }

        public IActionResult Status()
        {
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Inloggen(string personeelnummer)
        {
            ViewBag.Visibility = "invisible";

            bool gevonden = false;
            var lijstPersonen = _context.Personen.ToList();

            foreach (var persoon in lijstPersonen)
            {
                if (persoon.Personeelnummer == personeelnummer)
                {
                    gevonden = true;
                }
            }

            try
            {
                if (gevonden)
                {
                    Persoon persoon = _context.Personen.Find(personeelnummer);
                    PersoonCRUDViewModel viewModel = new PersoonCRUDViewModel()
                    {
                        Personeelnummer = persoon.Personeelnummer,
                        Naam = persoon.Naam,
                        Voornaam = persoon.Voornaam,
                        Admin = persoon.Admin
                    };

                    return View(viewModel);
                }
                else
                {
                    ViewBag.Class = "alert alert-danger mb-5";
                    ViewBag.Visibility = "visible";

                    return View(nameof(Inloggen));
                }

            }
            catch (Exception)
            {
                throw;
            }
            return View();
        }
    }
}
