using System.ComponentModel.DataAnnotations;

namespace Boekingssysteem.Models
{
    public class Vak
    {
        public int VakID { get; set; }

        [Required]
        public string Naam { get; set; }
    }
}
