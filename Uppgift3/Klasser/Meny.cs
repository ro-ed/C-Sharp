

using System;

namespace Klasser
{
    public class Meny
    {
        public static void Meny1()
        {


            Console.Write("Välkommen! I detta program kan du göra följande: ");
            Console.Write("\n[1] Lägg till ny bil.");
            string nyBil = Console.ReadLine();
            int nyBilSiffra = int.Parse(nyBil);
            Console.Write("\n[2] Sök info om bil.");
            Console.Write("\n[3] Ändra milmätaren.");
            Console.Write("\n[4] Ändra information om din bil..");
        }
    }
}
