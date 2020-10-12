using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Klasser;


namespace ArvOchAbstraktion
{
    public interface IVerkstad
    {
        void LäggTillFordon(Fordon fordon);
        void TaBortFordon(Fordon fordon);
        Fordon HittaFordon(string regNr);
        
    }
}
