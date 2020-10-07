using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Klasser
{

    public class Bil : Program 
    {

        

        //public Dictionary<string, Bil> BilDataBas = new Dictionary<string, Bil>();

        public string _modellNamn;
        public decimal _milMätare;
        //public static decimal Milmätare { get; set; }
        public string Ägare { get; set; }
        public  string BilMärkeInput { get; set; }      
        public  int ViktInput { get;  set; }
        public  string RegistreringsnummerInput { get; set; }
        public  bool ElbilInput { get; set; }
        public  DateTime Registrerades { get; set; }  
        public override string ToString()
        {
                     return $"----------------------------------------------------------------------------------------" + $"\nBilmärke: {BilMärkeInput}, \nModell: {_modellNamn}, \nVikt: {ViktInput},\nRegnummer: {RegistreringsnummerInput}, \nElbil: {ElbilInput}, \nRegistrerades: {Registrerades}, \nMilmätare: {_milMätare}" +
                $"\n----------------------------------------------------------------------------------------";
        }
        public static void ÄndraMilmätare()
        {
            int personIndex = -1;
            while (true)
            {


                Console.Write("Ange namn på person som du vill lägga till bil på: ");
                string personNamn = Console.ReadLine();


                for (int i = 0; i < användare.Count; i++)
                {
                    if (användare[i].Namn == personNamn)
                    {
                        personIndex = i;
                    }
                }






                Console.Write("Ange regnummer på den bil du vill ändra milmätare på: ");
                var ändraMätarBil = Console.ReadLine();
                

                for (int i = 0; i < bilar.Count; i++)
                {
                    if (bilar[i].Ägare == _username && bilar[i].RegistreringsnummerInput == ändraMätarBil)
                    {
                        Console.Write("Ange antal mil du vill lägga till: ");
                        decimal milInput = Convert.ToDecimal(Console.ReadLine());
                        if (milInput < bilar[i]._milMätare)
                        {

                            Console.WriteLine("Miltalet du angav var mindre än det ursprungliga. Prova igen.");
                            Console.ReadLine();

                            ÄndraMilmätare();
                        }
                        else
                        {
                            bilar[i]._milMätare += milInput;
                        }

                    }
                }
                        Console.Clear();
                        MENU();
                
             
            }
            
        }
        public string GetMil()
        {
            return _milMätare.ToString();
        }
    }     
}
       
