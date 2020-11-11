using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fajlkezeles_3
{
    class Program
    {
        //így készült régen

        //public struct felosztas
        //{
        //    public string telepules;
        //    public string ido;
        //    public string szelirany;
        //    public int homerseklet;
        //}

        static void Main(string[] args)
        {
            // lista osztály és struktúra osztály elkészítése

            var adatfelepites = new Adatfelepites();
            var adatlista = new Adatlista();

            var fajlnev = "tavirathu13.txt";
            using (var fs = new FileStream(fajlnev, FileMode.Open))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        var sor = sr.ReadLine();
                        string[] darabol = sor.Split(' ');
                        var a = new Adatfelepites();
                        a.telepules = darabol[0];
                        a.ido = darabol[1];
                        a.szelirany = darabol[2];
                        a.homerseklet = Convert.ToInt32(darabol[3]);
                        adatlista.Adat.Add(a);
                    }
                }
            }

            //Console.WriteLine(string.Join(" ,", adatlista.Adat) );
            // kiíratás ellenőrzés!
            foreach (var item in adatlista.Adat)
            {
                Console.WriteLine($"{item.telepules},{item.ido} ");
            }


            Console.ReadLine();


        }
    }
}
