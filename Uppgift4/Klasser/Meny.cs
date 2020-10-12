//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;


//namespace Klasser
//{
//    public class Meny : Fordon
//    {
//        public static void SkapaAnvändare()
//        {
//            while (true)
//            {
                
//                Console.WriteLine("=====NY ANVÄNDARE=====");
//                Console.WriteLine("Skapa ny användare:");
//                Användare nyAnvändare = new Användare();
//                Console.Write("\nAnge användarnamn: ");
//                Användare.User_Name = Console.ReadLine();                
//                Console.Write("Ange lösenord: ");
//                Användare.User_Password = Console.ReadLine();
//                Console.Write("Ange ålder: ");
//                int.TryParse(Console.ReadLine(), out int skapaÅld);
//                Användare.User_Age = skapaÅld;                
//                Användare.AllaAnvändare.Add(nyAnvändare);
//                Console.Clear();
//                break;
//            }
//        }
        
//        public static void LoggaIn()
//        {
//            while (true)
//            {
//                Console.WriteLine("=====LOGIN=====");
//                Console.Write("Ange användarnamn: ");
//                var angivenAnv = Console.ReadLine();

//                foreach (var item in Användare.AllaAnvändare)
//                {


//                    if (angivenAnv == Användare.User_Name)
//                    {
//                        Console.WriteLine("Rätt användarnamn!");
//                        Console.ReadLine();
//                        Console.Clear();
                        
//                    }
//                    else
//                    {
//                        Console.WriteLine("Användarnamnet finns inte! Prova igen!");
//                        Console.ReadLine();
//                        Console.Clear();


//                    }
//                }
//                Console.Write("Ange lösenord: ");
//                var angivetLös = Console.ReadLine();

//                foreach (var item in Användare.AllaAnvändare)
//                {                   

//                    if (angivetLös == Användare.User_Password)
//                    {
//                        Console.WriteLine("Du angav rätt uppgifter!");
//                        Console.ReadLine();
//                        Console.Clear();
                        
//                    }
//                    else
//                    {
//                        Console.WriteLine("Du angav fel uppgifter!");
//                        Console.ReadLine();
//                        Console.Clear();


//                    }
//                }
                
//             break;
//            }
//        }
        
//        public static void HuvudMeny()
//        { 
//            while (true) 
//            { 

//            Console.WriteLine("Välkommen till VERKSTADEN!");
//            Console.WriteLine($"\nDu är inloggad som: [{Användare.User_Name}]");
//            Console.WriteLine("\nI detta program kan du lägga till fordon och ta bort fordon ifrån en virtuell verkstad.");
//            Console.WriteLine("Välj ett av alternativen nedan: ");
//            Console.WriteLine("\n1. Lägg till fordon i verkstaden.");
//            Console.WriteLine("2. Ta bort fordon från verkstaden.");
//            Console.WriteLine("3. Stäng program.");
//            string svar = Console.ReadLine();
//            int.TryParse(Console.ReadLine(), out int svarNum);

           
            
//                if (svarNum == 1)
//                {
//                    Console.WriteLine("I den här verkstaden tar vi emot följande fordon:");
//                    Console.WriteLine("1. Bil");
//                    Console.WriteLine("2. Motorcykel");
//                    Console.WriteLine("3. Lastbil");
//                    Console.WriteLine("4. Buss");
//                    Console.Write("Vad för sorts fordon vill du lägga till i verkstaden? ");
//                    string läggSvar = Console.ReadLine();
//                    int.TryParse(Console.ReadLine(), out int läggSvarNum);

//                    switch (läggSvarNum)
//                    {
//                        case 1:
//                            Console.WriteLine("=====NY BIL=====");
//                            Bil nyBil = new Bil();
//                            Console.Write("Ange märke på bil: ");
//                            Fordon.Märke = Console.ReadLine();
//                            Console.Write("Ange modell på bil: ");
//                            Fordon.Modellnamn = Console.ReadLine();
//                            Console.Write("Ange vikt på bil: ");
//                            Fordon.Vikt = int.Parse(Console.ReadLine());
//                            Console.Write("Ange registreringsnummer på bil: ");
//                            Fordon.Registreringsnummer = Console.ReadLine();
//                            Console.Write("Ange miltal på bil: ");
//                            Fordon.Milmätare = int.Parse(Console.ReadLine());
//                            Console.Write("Har bilen dragkrok? JA/NEJ: ");
//                            if (Console.ReadLine().ToUpper() == "JA")
//                            {
//                                Bil.HarDragkrok = true;
//                            }
//                            Fordon.RegistreringsDatum = DateTime.Now;
//                            Fordon.Bilar.Add(nyBil);
                            
                            
//                            break;

//                        case 2:
//                            Console.WriteLine("=====NY MOTORCYKEL=====");
//                            Motorcykel nyMotorcykel = new Motorcykel();
//                            Console.Write("Ange märke: ");
//                            Fordon.Märke = Console.ReadLine();
//                            Console.Write("Ange modell: ");
//                            Fordon.Modellnamn = Console.ReadLine();
//                            Console.Write("Ange vikt: ");
//                            Fordon.Vikt = int.Parse(Console.ReadLine());
//                            Console.Write("Ange registreringsnummer: ");
//                            Fordon.Registreringsnummer = Console.ReadLine();
//                            Console.Write("Ange miltal: ");
//                            Fordon.Milmätare = int.Parse(Console.ReadLine());
//                            Console.Write("Ange max fart: ");
//                            Motorcykel.MaxFart = int.Parse(Console.ReadLine());
//                            Fordon.RegistreringsDatum = DateTime.Now;
//                            Fordon.Motorcyklar.Add(nyMotorcykel);
//                            break;

//                        case 3:
//                            Console.WriteLine("=====NY LASTBIL=====");
//                            Lastbil nyLastbil = new Lastbil();
//                            Console.Write("Ange märke på bil: ");
//                            Fordon.Märke = Console.ReadLine();
//                            Console.Write("Ange modell på bil: ");
//                            Fordon.Modellnamn = Console.ReadLine();
//                            Console.Write("Ange vikt på bil: ");
//                            Fordon.Vikt = int.Parse(Console.ReadLine());
//                            Console.Write("Ange registreringsnummer på bil: ");
//                            Fordon.Registreringsnummer = Console.ReadLine();
//                            Console.Write("Ange miltal på bil: ");
//                            Fordon.Milmätare = int.Parse(Console.ReadLine());
//                            Console.Write("Ange max last: ");
//                            Lastbil.MaxLast = int.Parse(Console.ReadLine());
//                            Fordon.RegistreringsDatum = DateTime.Now;
//                            Fordon.Lastbilar.Add(nyLastbil);
//                            break;

//                        case 4:
//                            Console.WriteLine("=====NY BUSS=====");
//                            Buss nyBuss = new Buss();
//                            Console.Write("Ange märke på bil: ");
//                            Fordon.Märke = Console.ReadLine();
//                            Console.Write("Ange modell på bil: ");
//                            Fordon.Modellnamn = Console.ReadLine();
//                            Console.Write("Ange vikt på bil: ");
//                            Fordon.Vikt = int.Parse(Console.ReadLine());
//                            Console.Write("Ange registreringsnummer på bil: ");
//                            Fordon.Registreringsnummer = Console.ReadLine();
//                            Console.Write("Ange miltal på bil: ");
//                            Fordon.Milmätare = int.Parse(Console.ReadLine());
//                            Console.Write("Ange max antal passagerare: ");
//                            Buss.MaxAntalPassagerare = int.Parse(Console.ReadLine());
//                            Fordon.RegistreringsDatum = DateTime.Now;
//                            Fordon.Bussar.Add(nyBuss);
//                            break;
//                    }
                    
//                }
//                else if (svarNum == 2)
//                {

//                }
//                else if (svarNum == 3)
//                {
//                    break;
//                }
//            }
//        }
//    }
//}

