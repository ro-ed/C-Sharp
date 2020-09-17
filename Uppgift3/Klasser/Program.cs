using System;
using System.Xml.Schema;

namespace Klasser
{
    public class Uppgift_3 : Meny
    {
        public static void Main(string[] args)
        {
            Meny1();
            CarProperties BMW = new CarProperties();
            Console.Write($"Model: {BMW.Model}");
            Console.ReadLine();
            
        }
    }
}
