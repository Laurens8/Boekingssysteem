using System.ComponentModel.DataAnnotations;

namespace Boekingssysteem.Models
{
    public class Status
    {
        public int StatusID { get; set; }

        [Required]
        public int PersoonID { get; set; }

        public bool? Aanwezig { get; set; }

        public bool? Onbekend { get; set; }
    }
}
