using System.ComponentModel.DataAnnotations;

namespace Boekingssysteem.ViewModels
{
    public class EditPersoonViewModel
    {
        public string Personeelnummer { get; set; }

        [Required]
        public string Naam { get; set; }

        [Required]
        public string Voornaam { get; set; }

        [Required]
        public bool Admin { get; set; }
    }
}
