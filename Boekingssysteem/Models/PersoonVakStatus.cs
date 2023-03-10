using System.ComponentModel.DataAnnotations;

namespace Boekingssysteem.Models
{
    public class PersoonVakStatus
    {
        public int PersoonVakStatusID { get; set; }

        [Required]
        public int PersoonID { get; set; }

        [Required]
        public int VakID { get; set; }
    }
}
