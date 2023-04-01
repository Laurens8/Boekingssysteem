﻿using Boekingssysteem.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Boekingssysteem.ViewModels
{
    public class PersoonCRUDViewModel
    {
        [Required(ErrorMessage = "Personeelnummer moet ingevuld zijn!")]
        [MinLength(8, ErrorMessage = "Een personeelnummer bestaat uit 8 tekens")]
        [MaxLength(8)]
        public string Personeelnummer { get; set; }
        [Required(ErrorMessage = "Naam moet ingevuld zijn!")]
        [MaxLength(15)]
        public string Naam { get; set; }
        [Required(ErrorMessage = "Voornaam moet ingevuld zijn!")]
        [MaxLength(15)]
        public string Voornaam { get; set; }
        public bool Admin { get; set; }
        public bool? Aanwezig { get; set; }

        public ICollection<Persoon> Personen { get; set; }
        public List<Persoon> lijstPersonen { get; set; }

        public ICollection<Functie> Functies { get; set; }
        public ICollection<Richting> Richtingen { get; set; }

        //Navigatieproperties
        public virtual ICollection<Afwezigheid> Afwezigheden { get; set; }
        public virtual ICollection<PersoonRichting> PersoonRichtingen { get; set; }
        public virtual ICollection<PersoonFunctie> PersoonFuncties { get; set; }
    }
}