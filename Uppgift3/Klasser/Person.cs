using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Person
    {
        public static List<Person> användare = new List<Person>();

        public static List<Bil> bilar = new List<Bil>();
        
        public static List<Bil> egnaBilar = new List<Bil>();
        public string Namn { get; set; }
        public string Ålder { get; set; }

        public string Lösenord { get; set; }

        public override string ToString()
        {
            return $"Namn: {Namn}, Ålder: {Ålder}";
        }
        public Person()
        {
            bilar = new List<Bil>();
        }






    }
}
