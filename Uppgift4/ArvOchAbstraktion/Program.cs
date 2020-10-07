using System;
using Klasser;
using System.Collections.Generic;

namespace ArvOchAbstraktion 
{
    public class Program
    {
        private List<Bil> _bilar;
        public List<Bil> Bilar { get; set; }

        private List<Motorcykel> _motorcyklar;
        public List<Motorcykel> Motorcyklar { get; set; }

        private List<Lastbil> _lastbilar;
        public List<Lastbil> Lastbilar { get; set; }
        
        private List<Buss> _bussar;
        public List<Buss> Bussar { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till VERKSTADEN!");
            Console.WriteLine("\nI detta program kan du lägga till fordon och ta bort fordon ifrån en virtuell verkstad.");
            Console.WriteLine("Välj ett av alternativen nedan: ");
            Console.WriteLine("1. Lägg till fordon i verkstaden.");
            Console.WriteLine("2. Ta bort fordon från verkstaden.");
            Console.WriteLine("3. Stäng program.");
            string svar = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out int svarNum);

            while (true)
            {
                if (svarNum == 1)
                {
                    Console.WriteLine("I den här verkstaden tar vi emot följande fordon:");
                    Console.WriteLine("1. Bil");
                    Console.WriteLine("2. Motorcykel");
                    Console.WriteLine("3. Lastbil");
                    Console.WriteLine("4. Buss");
                    Console.Write("Vad för sorts fordon vill du lägga till i verkstaden? ");
                    string läggSvar = Console.ReadLine();
                    int.TryParse(Console.ReadLine(), out int läggSvarNum);

                    switch (läggSvarNum)
                    {
                        case 1:
                            break;

                        case 2:
                            break;

                        case 3:
                            break;

                        case 4:
                            break;

                    }
                }
            }
        }
    }
}
