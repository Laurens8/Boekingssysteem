
using Boekingssysteem.Data;
using Boekingssysteem.Lib;
using Boekingssysteem.Models;
using Boekingssysteem.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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

        //[Authorize(Roles = "admin")]
        public IActionResult AdminView()
        {
            return View();
        }

        public IActionResult GebruikerView()
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
        public IActionResult Index(string personeelnummer)
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
                    return RedirectToAction("GebruikerView");
                }
                else
                {
                    ViewBag.Class = "alert alert-danger mb-5";
                    ViewBag.Visibility = "visible";

                    return View();
                }

            }
            catch (Exception e)
            {
                Foutenlogboek.FoutLoggen(e);
            }
            return View();
        }
    }
}
