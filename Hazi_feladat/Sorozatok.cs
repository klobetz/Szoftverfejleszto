using System;
using System.Collections.Generic;
using System.Linq;

namespace Hazi_feladat
{
    public class Sorozatok
    {
        //public Sorozatok()
        //{
            
        //}
        
        public int Bekeres()
        {
            Console.Write("Kérek egy egész számot: ");

            var valasz = Console.ReadLine();

            int szam;
            while (!int.TryParse(valasz, out szam) || szam <= 0)
            {
                Console.WriteLine("Rossz értéket adtál meg, csak 0-a vagy pozitív egész számot használhatsz!");
                valasz = Console.ReadLine();
            }

            return szam;
        }

        public List<int> Feltoltes(int szam)
        {
            var list = new List<int>();
            var r = new Random();

            for (int i = 0; i < szam; i++)
            {
                list.Add(r.Next(1, 1001));
            }

            return list;
        }
    }
}