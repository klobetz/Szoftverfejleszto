using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hány éves a kapitány?");
            var valasz = Console.ReadLine();
           
            var valasz1 = Convert.ToInt32(Console.ReadLine());


            int szam; //ez azért kell hogy a TryParse bele tudjon írni a függvényembe
            //var valasz1 = 10;
            //var valasz2 = 20;


            //Console.WriteLine("a megadott érték: {0} {1} {2}", valasz1, valasz2);
            //Console.WriteLine($"a megadott érték:{valasz} {valasz1} {valasz2}");

            if (int.TryParse(valasz,out szam))
            {
                Console.WriteLine($"A kapitány: {szam} éves");
            }
            else
            {
                Console.WriteLine("nem sikerült az átalakítás!");
            }

            Console.WriteLine($"a másik megoldás eredménye: { valasz1}");


            Console.ReadLine();
        }
    }
}
