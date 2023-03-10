﻿using Boekingssysteem.Models;
using System.Collections.Generic;

namespace Boekingssysteem.ViewModels
{
    public class PersoonListViewModel
    {
        public List<Persoon> Personen { get; set; }

        public List<Afwezigheid> Afwezigheden { get; set; }

        public List<PersoonRichting> PersoonRichtingen { get; set; }
    }
}
