using System;
using System.Collections.Generic;
using System.Linq;

namespace Hazi_feladat
{
    public class Sorozatok
    {
        public Sorozatok()
        {
            Console.Write("Kérek egy egész számot: ");

            var valasz = Console.ReadLine();

            int szam;
            while (!int.TryParse(valasz, out szam) || szam <= 0)
            {
                Console.WriteLine("Rossz értéket adtál meg, csak 0-a vagy pozitív egész számot használhatsz!");
                valasz = Console.ReadLine();
            }
            

            var list = new List<int>();
            var r = new Random();

            for (int i = 0; i < szam; i++)
            {
                list.Add(r.Next(1, 1001));
            }
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

        }
    }
}