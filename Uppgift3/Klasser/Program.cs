using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace Klasser
{
    public class Program : Meny
    {
        //public Dictionary<string, string> BilDataBas = new Dictionary<string, string>();



        public static List<Person> användare = new List<Person>();

        public static List<Bil> bilar = new List<Bil>();


        public static void Main(string[] args)
        {

            while (true)
            {


                Bil bil1 = new Bil()
                {

                    BilMärkeInput = "BMW",
                    _modellNamn = "Z3",
                    ViktInput = 1500,
                    RegistreringsnummerInput = "AAA123",
                    ElbilInput = true,
                    Registrerades = DateTime.Now,
                    
                };

                bilar.Add(bil1);

                Bil bil2 = new Bil()
                {
                    BilMärkeInput = "Toyota",
                    _modellNamn = "Avensis",
                    ViktInput = 2000,
                    RegistreringsnummerInput = "BBB123",
                    ElbilInput = true,
                    Registrerades = DateTime.Now,
                    
                };

                bilar.Add(bil2);

                Bil bil3 = new Bil()
                {
                    BilMärkeInput = "Audi",
                    _modellNamn = "A6",
                    ViktInput = 1900,
                    RegistreringsnummerInput = "CCC123",
                    ElbilInput = false,
                    Registrerades = DateTime.Now,
                    
                };

                bilar.Add(bil3);

                Bil bil4 = new Bil()
                {
                    BilMärkeInput = "Opel",
                    _modellNamn = "Astra",
                    ViktInput = 1800,
                    RegistreringsnummerInput = "AAB123",
                    ElbilInput = false,
                    Registrerades = DateTime.Now,
                    

                };

                bilar.Add(bil4);


                // NU FINNS DET 4 BILAR I LISTAN


                Console.WriteLine("Det har skapats fyra bilar i listan.");
                Console.Write("\nVill du se vilka bilar som skapats? JA/NEJ: ");
                string svaret = Console.ReadLine();
                if (svaret.ToUpper() == "JA")
                {
                    Console.WriteLine("\n----------------------------------------------------------------------------------------");
                    foreach (var specifikBil in bilar)

                    Console.WriteLine(specifikBil);
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.ReadLine();

                    Console.Clear();
                    WELCOME();



                }

                // FÅR RESULTATET KLASSER.BIL 4 GGR.

                else if (svaret.ToUpper() == "NEJ")
                {
                    Console.Clear();
                    WELCOME();

                }
                else
                {
                    Console.WriteLine("\nDu har angett något annat. Programmet stängs ner.");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine("----------------------------------------------------------------------------------------");
                break;
            }
        }

        //internal static void MakeCar()
        //{
        //    throw new NotImplementedException();
        //}

        public static void MakeCar() // ALTERNATIV 1
        {

            Console.Write("Ange bilmärke: ");
            var märke = Console.ReadLine();
            Console.Write("Ange modell: ");
            var model = Console.ReadLine();
            Console.Write("Ange vikt: ");
            var vikt = int.Parse(Console.ReadLine());
            Console.Write("Ange registreringsnummer: ");
            var registreringsnummer = Console.ReadLine();
            Console.Write("Är det en elbil? JA/NEJ: ");
            var ärElbil = Console.ReadLine();

            bool elbil = false;
            if (ärElbil.ToUpper() == "JA")
            {
                elbil = true;
            }
                // SKAPAR NY BIL
            var nyBil = new Bil();
            nyBil.Ägare = _username;
            nyBil.BilMärkeInput = märke;
            nyBil._modellNamn = model;
            nyBil.ViktInput = vikt;
            nyBil.RegistreringsnummerInput = registreringsnummer;
            nyBil.ElbilInput = elbil;
            nyBil.Registrerades = DateTime.Now;    
            Person.bilar.Add(nyBil);
            bilar.Add(nyBil);
                
                //CarProperties new_car = new CarProperties();
                //new_car.Set_info(new_car, märke, model);

                //Console.WriteLine(nyBil);
            Console.ReadLine();
            }
        public static void VisaAnvändarnasBilar() // ALTERNATIV 5
        {
            
            foreach (Person anv in användare)
            {
                Console.WriteLine($"\nPersonen {anv.Namn} är {anv.Ålder} gammal och har bilarna:");
               


                foreach (Bil specifikBil in Person.bilar)
                {
                    Console.WriteLine($"Bilmärke: {specifikBil.BilMärkeInput}");
                    Console.WriteLine($"Modell: {specifikBil._modellNamn}");
                    Console.WriteLine($"Vikt: {specifikBil.ViktInput}");
                    Console.WriteLine($"Registreringsnummer: {specifikBil.RegistreringsnummerInput}");
                    Console.WriteLine($"Registrerades: {specifikBil.Registrerades}");
                    Console.WriteLine($"Milmätare: {specifikBil.GetMil()}");
                    if (specifikBil.ElbilInput)
                    {
                        Console.WriteLine("Detta är en elbil!");
                    }
                    Console.ReadLine();
                    Console.Clear();
                    MENU();
                }
                
            }
        }

        public static void SkapaAnvändare()
        {          
            Console.Write("\nAnge nytt namn: ");
            var nyNamn = Console.ReadLine();
            Console.Write("Ange ålder: ");
            var nyÅlder = Console.ReadLine();
            Console.Write("Ange nytt lösenord: ");
            var nyNLösenord = Console.ReadLine();
            var newUser = new Person();
            newUser.Namn = nyNamn;
            newUser.Lösenord = nyNLösenord;
            newUser.Ålder = nyÅlder;
            användare.Add(newUser);
            Console.Clear();
            LOGIN();
        }
        public static void SeAllaBilar()
        {
            foreach (var specifikBil in bilar)

            Console.WriteLine(specifikBil);
            Console.ReadLine();
            Console.Clear();
            MENU();
        }
    }
}
        
    

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        //public static void SökaAnvändare()
        //{
        //    Console.Write("Ange namnet du söker: ");
        //    var namnSök = Console.ReadLine();

        //}  

        //    public static void byterText()
        //    {
        //        Console.WriteLine("Detta är en elbil.");
        //        var byterText = Console.ReadLine();
        //        byterText = byterText.Replace();
        //    }

    





















