namespace Klasser
{

    public class CarProperties
    {
        public string Registreringsnummer { get; set; }

        public string Model;
        public string Vikt;
        public bool Elbil;
        public CarProperties()
        {
            Model = "Z3";
            Vikt = "100";
            Elbil = true;
            Registreringsnummer = "ABC123";
        }
    }
}