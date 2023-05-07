﻿
using Boekingssysteem.Areas.Identity.Data;
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
        private readonly SignInManager<CustomUser> _signInManager;
        private readonly ILogger<HomeController> _logger;

        public HomeController(BoekingssysteemContext context, SignInManager<CustomUser> signInManager, ILogger<HomeController> logger)
        {
            _context = context;
            _signInManager = signInManager;
            _logger = logger;
        }

        public IActionResult Index()
        {         
            var login = _signInManager.IsSignedIn(User);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[Authorize(Roles = "admin")]
        public IActionResult AdminView()
        {
            var login = _signInManager.IsSignedIn(User);
            return View(login);
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
