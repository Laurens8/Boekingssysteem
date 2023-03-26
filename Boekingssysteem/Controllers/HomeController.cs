
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

        public IActionResult Inloggen(string personeelnummer)
        {
            try
            {
                var persoon = _context.Personen.Where(p => p.Personeelnummer == personeelnummer).FirstOrDefault();
                if (persoon != null)
                {
                    if (persoon.Admin == true)
                    {
                        return View("AdminView");
                    }
                    else
                    {
                        return View(Status());
                    }
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
