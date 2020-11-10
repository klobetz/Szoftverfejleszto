using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Lista_valogatas
{
    public class Valogatas
    {
        public int Bekeres()
        {
            Console.Write("Kérek egy szmot: ");
            var valasz = Console.ReadLine();
            int szam;
            while (!int.TryParse(valasz, out szam))
            {
                Console.WriteLine("Nem jó számot adtál meg kérlek isételd meg újra!");
                valasz = Console.ReadLine();
            }
            return szam;
        }

        public List<int> Feltolt(int szam)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < szam; i++)
            {
                list.Add(r.Next(1, 101));
            }

            return list;
        }

        public void Vizsgalat(List<int> list, out List<int> paros, out List<int> paratlan)
        {
            paros = new List<int>();
            paratlan = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    paros.Add(list[i]);
                }
                else
                {
                    paratlan.Add(list[i]);
                }
            }
        }
    }
}