using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public abstract class Fordon
    {
        private List<Bil> _bilar;
        public  List<Bil> Bilar 
        {

            get
            {
                if (_bilar == null)
                {
                    _bilar = new List<Bil>();
                }
                return _bilar;
            }
        }

        private  List<Motorcykel> _motorcyklar;
       
        public  List<Motorcykel> Motorcyklar
        {

            get
            {
                if (_motorcyklar == null)
                {
                    _motorcyklar = new List<Motorcykel>();
                }
                return _motorcyklar;
            }
        }

        private  List<Lastbil> _lastbilar;
        public  List<Lastbil> Lastbilar
        {

            get
            {
                if (_lastbilar == null)
                {
                    _lastbilar = new List<Lastbil>();
                }
                return _lastbilar;
            }
        }

        private  List<Buss> _bussar;
        public  List<Buss> Bussar
        {

            get
            {
                if (_bussar == null)
                {
                    _bussar = new List<Buss>();
                }
                return _bussar;
            }
        }

        public   string Märke { get; set; }
        public   string Modellnamn { get; set; }
        public   int Vikt { get; set; }
        public   string Registreringsnummer { get; set; }
        public   int Milmätare { get; set; }
        public   DateTime RegistreringsDatum { get; set; }
            
    }
}
