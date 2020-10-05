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
        private static decimal _milMätare;

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

                foreach (var bil in Person.egnaBilar)
                {
                    if (bil.RegistreringsnummerInput == ändraMätarBil && användare[personIndex].Namn == personNamn)
                    {
                        decimal mil = 0;
                        Console.Write("Ange antal mil du vill lägga till: ");
                        decimal milInput = Convert.ToDecimal(Console.ReadLine());


                        if (milInput > mil)
                        {
                            mil = milInput;
                            _milMätare += mil;
                            
                        }
                        else if (milInput < mil)
                        {
                            Console.WriteLine("Miltalet du angav var mindre än det ursprungliga. Prova igen.");
                            Console.ReadLine();
                            ÄndraMilmätare();
                        }
                        Console.Clear();
                        MENU();
                    }
                    
                }
                
                }
            
            }
        public  string GetMil()
        {
            return _milMätare.ToString();
        }
        }






























        //public void skapa(Bil nyBil)
        //{
        //    Console.Write("Ange bilmärke: ");
        //    BilMärkeInput = Console.ReadLine();

        //    Console.Write("Ange model: ");
        //    ModelInput = Console.ReadLine();

        //    Console.Write("Ange registreringsnummer: ");
        //    RegistreringsnummerInput = Console.ReadLine();

        //    Console.Write("Ange antal mil som bilen gått: ");
        //    Milmätare = Convert.ToDecimal(Console.ReadLine());

        //    Console.Write("Ange om det är en elbil: J/N ");
        //    string boolSvar = Console.ReadLine();
        //    if (boolSvar.ToLower() == "j")
        //    {
        //        ElbilInput = true;

        //    }

        //    Registrerades = DateTime.Now;


        //    bilar.Add(nyBil);

        //}
        //public static List<Bil> Get_List()
        //{
        //    return bilar;
        //}


















    }


