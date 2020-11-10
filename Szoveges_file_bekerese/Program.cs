using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szoveges_file_bekerese
{
    class Program
    {
        static void Main(string[] args)
        {
            szovegbekeres();


            Console.ReadLine();
        }        

        public static void szovegbekeres()
        {
            Console.Write("Kérek egy szöveget: ");
            var valasz = Console.ReadLine();
            while (double.TryParse(valasz, out double szam))
            {
                Console.WriteLine("Számot adtál meg kérek egy új bevitelt. Figyelj hogy csak szöveg legyen!");
                valasz = Console.ReadLine();
            }
            Console.WriteLine("Köszönöm!");
        }
       
    }

    
}
