using Boekingssysteem.Areas.Identity.Data;
using Boekingssysteem.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Boekingssysteem.ViewModels
{
    public class GebruikerListViewModel : Controller
    {
        public List<CustomUser> Gebruikers { get; set; }
        public List<Persoon> Roles { get; set; }
    }
}
