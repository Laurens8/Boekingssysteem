using Boekingssysteem.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Boekingssysteem.ViewModels
{
    public class GebruikerListViewModel : Controller
    {
        public List<CustomUser> Gebruikers { get; set; }
    }
}
