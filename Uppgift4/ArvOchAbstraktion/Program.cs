using System;
using Klasser;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ArvOchAbstraktion
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "Verkstad";
            IVerkstad vs = new Verkstad();

            while (true)
            {
                Console.WriteLine("Ange något av alternativen:");
                Console.WriteLine("1. Skapa bil.");
                Console.WriteLine("2. Skapa motorcykel.");
                Console.WriteLine("3. Skapa lastbil.");
                Console.WriteLine("4. Skapa buss.");
                Console.WriteLine("5. Ta bort fordon.");
                //Console.WriteLine("6. Se alla fordon.");
                Console.WriteLine("6. Avsluta programmet.");
                int alternativ = int.Parse(Console.ReadLine());

                Fordon f = null;
                switch (alternativ)
                {
                    case 1:
                        f = SkapaBil();
                        vs.LäggTillFordon(f);
                        break;
                    case 2:
                        f = SkapaMotorcykel();
                        vs.LäggTillFordon(f);
                        break;
                    case 3:
                        f = SkapaLastbil();
                        vs.LäggTillFordon(f);
                        break;
                    case 4:
                        f = SkapaBuss();
                        vs.LäggTillFordon(f);
                        break;
                    case 5:
                        TaBortFordon(vs);
                        break;              
                }
                //if (alternativ == 6)
                //{             
                //    Console.WriteLine(Verkstad._fordonIVerkstad.ToString());
                //    Console.ReadLine();
                //    break;
                //}
                if (alternativ == 6)
                {
                    break;
                }

                
                //SkapaAnvändare();
                //LoggaIn();
                //HuvudMeny();

            }

        }
       
        public static Bil SkapaBil()
        {
            Bil bil = new Bil();
            SkapaFordon(bil);
            Console.Write("Har bilen dragkrok? JA/NEJ: ");
            string svar = Console.ReadLine();
            bool harDragkrok = false;
            if (svar.ToUpper() == "JA")
            {
                harDragkrok = true;
            }
            bil.HarDragkrok = harDragkrok;
            return bil;
        }


        public static Motorcykel SkapaMotorcykel()
        {
            Motorcykel mc = new Motorcykel();
            SkapaFordon(mc);
            Console.Write("Ange max fart: ");
            int.TryParse(Console.ReadLine(), out int maxFart);

            mc.MaxFart = maxFart;
            return mc;
        }
        public static Lastbil SkapaLastbil()
        {
            Lastbil lb = new Lastbil();
            SkapaFordon(lb);
            Console.Write("Ange max last i kilo: ");
            int maxLast = int.Parse(Console.ReadLine());

            lb.MaxLast = maxLast;
            return lb;
        }
        public static Buss SkapaBuss()
        {
            Buss buss = new Buss();
            SkapaFordon(buss);
            Console.Write("Ange max antal passagerare: ");
            int maxPass = int.Parse(Console.ReadLine());

            buss.MaxAntalPassagerare = maxPass;
            return buss;
        }
        private static void SkapaFordon(Fordon fordon)
        {
            Console.WriteLine("Ange modellnamn:");
            string modellnamn = Console.ReadLine();
            Console.WriteLine("Ange regnr:");
            string regNr = Console.ReadLine();
            Console.WriteLine("Ange mätare:");
            int matare = int.Parse(Console.ReadLine());
            DateTime registreringsDatum = DateTime.Now;

            fordon.Modellnamn = modellnamn;
            fordon.Milmätare = matare;
            fordon.RegistreringsDatum = registreringsDatum;
            fordon.Registreringsnummer = regNr;

        }
        private static void TaBortFordon(IVerkstad vs)
        {
            Console.WriteLine("Ange regnummer på fordon du vill ta bort: ");
            string regNr = Console.ReadLine();
            Fordon fordonSomSkaBort = vs.HittaFordon(regNr);
            vs.TaBortFordon(fordonSomSkaBort);
        }
    }
}
