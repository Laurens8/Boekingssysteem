﻿using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Boekingssysteem.Areas.Identity.Data
{
    public class CustomUser : IdentityUser
    {
        [PersonalData]
        public string Naam { get; set; }
        [PersonalData]
        public string Personeelnummer { get; set; }
        [PersonalData]
        public string Voornaam { get; set; }
    }
}
