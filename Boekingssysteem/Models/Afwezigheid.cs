using System.ComponentModel.DataAnnotations;
using System;

namespace Boekingssysteem.Models
{
    public class Afwezigheid
    {
        public int AfwezigheidID { get; set; }

        [Required]
        public int PersoonID { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Begindatum { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EindDatum { get; set; }
    }
}
