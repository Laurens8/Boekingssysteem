using Boekingssysteem.Models;
using System.Collections.Generic;

namespace Boekingssysteem.ViewModels
{
    public class AfwezigheidListViewModel
    {
        public List<Afwezigheid> Afwezigheden { get; set; }
        public List<Persoon> Personen { get; set; }
    }
}
