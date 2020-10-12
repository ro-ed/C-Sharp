using System;
using System.Collections.Generic;
using System.Text;
using Klasser;

namespace ArvOchAbstraktion
{
    class VerkstadV2 : IVerkstad
    {
        private List<Fordon> _fordonIVerkstad = new List<Fordon>();
        public void LäggTillFordon(Fordon fordon)
        {
            throw new NotImplementedException();
        }

        public void TaBortFordon(Fordon fordon)
        {
            throw new NotImplementedException();
        }
        public Fordon HittaFordon(string regNr)
        {
            throw new NotImplementedException();
        }
    }
}
