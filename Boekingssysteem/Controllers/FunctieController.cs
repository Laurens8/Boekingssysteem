using Boekingssysteem.Data;
using Boekingssysteem.Models;
using Boekingssysteem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Boekingssysteem.Controllers
{
    public class FunctieController : Controller
    {
        private readonly BoekingssysteemContext _context;

        public FunctieController(BoekingssysteemContext context)
        {
            _context = context;
        }

        public ViewResult Index()
        {
            return View();
        }
    }
}