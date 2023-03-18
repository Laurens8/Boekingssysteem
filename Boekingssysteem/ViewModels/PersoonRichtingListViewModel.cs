using Boekingssysteem.Models;
using System.Collections.Generic;

namespace Boekingssysteem.ViewModels
{
    public class PersoonRichtingListViewModel
    {
        public List<PersoonRichting> PersoonRichtingen { get; set; }
        public List<Persoon> Personen { get; set; }
    }
}
