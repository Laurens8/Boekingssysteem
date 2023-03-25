using Boekingssysteem.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Boekingssysteem.ViewModels
{
    public class EditPersoonViewModel
    {
        public string PersoonSearch { get; set; }
        public Persoon Persoon { get; set; }
        public List<Persoon> Personen { get; set; }

        [Key]
        [Required(ErrorMessage = "Personeelnummer moet ingevuld zijn!")]
        [MinLength(8)]
        [MaxLength(8)]
        public string Personeelnummer { get; set; }
        [Required(ErrorMessage = "Naam moet ingevuld zijn!")]
        public string Naam { get; set; }
        [Required(ErrorMessage = "Voornaam moet ingevuld zijn!")]
        public string Voornaam { get; set; }
        [Required(ErrorMessage = "Admin moet ingevuld zijn!")]
        public bool Admin { get; set; }
        public bool? Aanwezig { get; set; }

        //Navigatieproperties
        public virtual ICollection<Afwezigheid> Afwezigheden { get; set; }
        public virtual ICollection<PersoonRichting> PersoonRichtingen { get; set; }
        public virtual ICollection<PersoonFunctie> PersoonFuncties { get; set; }
        public virtual ICollection<Functie> Functies { get; set; }
    }
}
