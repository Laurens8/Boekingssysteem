using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Boekingssysteem.Models
{
    public class Persoon
    {
        public int PersoonID { get; set; }

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
