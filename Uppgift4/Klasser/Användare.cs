using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Användare
    {
        public static List<Användare> AllaAnvändare = new List<Användare>();
                  
        public static string User_Name { get; set; }
        public static string User_Password { get; set; }
        public static int User_Age { get; set; }     
        public override string ToString()
        {
            return User_Name;
        }
    }
}
