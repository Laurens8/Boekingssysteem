using Boekingssysteem.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Boekingssysteem.ViewModels
{
    public class PersoonViewModel
    {
        public List<Persoon> Personen { get; set; }

        public int PersoonID { get; set; }

        public int StatusID { get; set; }

        [Required]
        public string Naam { get; set; }

        [Required]
        public string Voornaam { get; set; }

        [Required]
        public bool Admin { get; set; }

        [Required]
        public string Personeelnummer { get; set; }
    }
}
