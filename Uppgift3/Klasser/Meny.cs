

using System;
using System.Collections.Generic;
using System.Linq;

namespace Klasser
{
    public  class Meny 
    {
        


        public static string _username;
        public static string _password;

        public static void WELCOME()
        {
            Console.WriteLine("Välkommen till detta program! I detta program kan du skapa bilar och ändra dess information.");
            Console.WriteLine("\n[1] Skapa ny användare. ");
            Console.WriteLine("[2] Logga in. ");
            int aSiffra = int.Parse(Console.ReadLine());
            if (aSiffra == 1)
            {
                Console.Clear();
                Program.SkapaAnvändare();
            }
            else
            {
                Console.Clear();
                LOGIN();

            }
        }
        
        
        
        
        
        public static string LOGIN()
        {
            while (true)
            {                
                Console.Write("ANVÄNDARNAMN: ");
                string userName = Console.ReadLine();               
                Console.Write("LÖSENORD: ");                
                string passWord = Console.ReadLine();
                foreach (var anv in Program.användare)
                {
                    if (userName == anv.Namn && passWord == anv.Lösenord)
                    {
                        Console.WriteLine("\nDu angav rätt uppgifter! Du loggas in! Tryck ENTER.");
                        _username = userName;
                        _password = passWord;
                        Console.ReadLine();
                        Console.Clear();
                        MENU();
                        
                    }
                }
                if (userName == "robin" && passWord == "rob123")
                {
                    Console.WriteLine("\nDu angav rätt uppgifter! Du loggas in! Tryck ENTER.");
                    _username = userName;
                    _password = passWord;
                    Console.ReadLine();
                    Console.Clear();
                    MENU();
                }
                else if (userName == "samuel" && passWord == "sam123")
                {
                    Console.WriteLine("\nDu angav rätt uppgifter! Du loggas in! Tryck ENTER.");
                    _username = userName;
                    _password = passWord;
                    Console.ReadLine();
                    Console.Clear();
                    MENU();
                }           
                else 
                {
                    Console.WriteLine("Du angav fel uppgifter. Prova igen.");
                    Console.ReadLine();
                    WELCOME();
                }

            }
        }
        public static void MENU()
        {
            

            while (true)
            {


                Console.Write("\nVälkommen! I detta program kan du välja mellan de fyra alternativen nedan. Skriv siffra och tryck ENTER. ");
                Console.WriteLine("\n\n[1] Lägg till ny bil. ");
                Console.WriteLine("[2] Ändra milmätaren för egen bil. ");              
                Console.WriteLine("[3] Se användarens fordon. ");
                Console.WriteLine($"[4] Logga ut: [{_username}] ");
                Console.WriteLine("[5] Se alla fordon. ");
                Console.Write("\nAnge siffra: ");
                
                string textsiffra = Console.ReadLine();
                int siffra = int.Parse(textsiffra);
                if (siffra == 1)
                {
                    Console.Clear();
                    Program.MakeCar();
                    Console.Clear();
                }               
                else if (siffra == 2)
                {
                    Console.Clear();
                    Bil.ÄndraMilmätare(); 

                }             
                else if (siffra == 3)
                {
                    Console.Clear();
                    Program.VisaAnvändarnasBilar();

                }
                else if (siffra == 4)
                {
                    Console.Clear();
                    WELCOME();
                }
                else if (siffra == 5)
                {
                    Console.Clear();
                    Program.SeAllaBilar();

                }
                else if (siffra <= 0 || siffra > 5)
                {
                    Console.Clear();
                    Console.Write("Ogilltig siffra. Prova igen.");

                }        
                
                
                            
            }

                   
                        
                    
                   
                  
                
        }



                
                
                

                
               
               

               




    }
}
    

