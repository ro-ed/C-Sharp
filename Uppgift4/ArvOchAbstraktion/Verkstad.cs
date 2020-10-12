using Klasser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArvOchAbstraktion
{
    public class Verkstad : IVerkstad
    {
        public static List<Fordon> _fordonIVerkstad = new List<Fordon>();
        public void LäggTillFordon(Fordon fordon)
        {
            _fordonIVerkstad.Add(fordon);
        }
        public void TaBortFordon(Fordon fordon)
        {
            _fordonIVerkstad.Remove(fordon);
        }
        public Fordon HittaFordon (string regNr)
        {
            foreach (Fordon fordon in _fordonIVerkstad)
            {
                if (fordon.Registreringsnummer == regNr)
                {
                    return fordon;
                }
                
            }
            return null;
        }
    }
}
            
          