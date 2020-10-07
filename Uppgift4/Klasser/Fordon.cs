using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public abstract class Fordon
    {
        public string Modellnamn { get; set; }
        public string Registreringsnummer { get; set; }
        public int Milmätare { get; set; }
        public DateTime RegistreringsDatum { get; set; }
            
    }
}
