using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            var sorozat = new Sorozatok();
           
            var szam = sorozat.Bekeres();            
           
            var list = sorozat.Feltoltes(szam);
            
            Console.Clear();
            
            Console.WriteLine($"Köszönom! A szám amit megadtál: {szam}");

            //írasd ki a sorozat utolsó elemét
            Console.WriteLine($"\nAz utolsó eleme: {list.Last()}");

            //írasd ki a sorozat eredményét egy sorba
            Console.WriteLine($"\nA sorozat elemei:");
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }

            //írasd ki a legnagyobb értékét
            Console.WriteLine($"\n\nA sorozat legnagyobb eleme: {list.Max()}");

            //írasd ki a legkisebb értékét
            Console.WriteLine($"\nA sorozat legkisebb eleme: {list.Min()}");

            //rendezd a sorozatot növekvő sorrendbe
            Console.WriteLine($"\nA sorozat elemi rendezve: ");
            list.Sort();
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }

            Console.ReadLine();
        }
    }
}
