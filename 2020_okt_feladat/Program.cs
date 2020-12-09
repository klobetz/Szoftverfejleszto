using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_okt_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            var adatLista = new List<Adatfelosztas>();
            var fajl = "lista.txt";
            using (var fs = new FileStream(fajl, FileMode.Open))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    //string[] adaSor = new string[5];                    
                    //int i = 0;
                    while (!sr.EndOfStream)
                    {
                        string[] adaSor = new string[5];
                        //var sor = sr.ReadLine();
                        var adatFelepites = new Adatfelosztas();
                        for (int i = 0; i < 5; i++)
                        {
                            adaSor[i] = sr.ReadLine();
                        }
                        adatFelepites.Datum = adaSor[0];
                        adatFelepites.Cim = adaSor[1];
                        adatFelepites.Resz = adaSor[2];
                        adatFelepites.Hossz = Convert.ToInt32(adaSor[3]);
                        adatFelepites.Latta = adaSor[4].Equals("1");
                        adatLista.Add(adatFelepites);
                        //adaSor[i] = sr.ReadLine();;
                        //i++;
                        //if (i==5)
                        //{
                        //    i = 0;
                        //    adatFelepites.Datum = adaSor[0];
                        //    adatFelepites.Cim = adaSor[1];
                        //    adatFelepites.Resz = adaSor[2];
                        //    adatFelepites.Hossz = Convert.ToInt32(adaSor[3]);
                        //    adatFelepites.Latta = adaSor[4].Equals("1");
                        //    adatLista.Add(adatFelepites);
                        //}
                    }
                }
            }
            //foreach (var adat in adatLista)
            //{
            //    Console.WriteLine($"{adat.Datum} {adat.Cim} {adat.Resz} {adat.Hossz} {adat.Latta}");
            //}

            //2.feladat
            var eredmeny = adatLista.Count(adat => adat.Datum != "NI");
            Console.WriteLine(eredmeny);

            var eredmeny2 = adatLista.Where(adat => adat.Datum != "NI").Select(adat => adat.Datum);
            Console.WriteLine(eredmeny2.Count());

            //3.feladat
            double lattaDb = adatLista.Count(adat => adat.Latta==true);
            double lattaOssz = adatLista.Count();
            Console.WriteLine((lattaDb/lattaOssz).ToString("p2"));

            //Console.WriteLine($"{Math.Round((lattaDb / lattaOssz * 100),2)}%");

            //Console.WriteLine(lattaOssz);

            //4.feladat
            var idoosszes = adatLista.Where(adat => adat.Latta == true).Sum(adat => adat.Hossz);
            var ido = TimeSpan.FromMinutes(idoosszes);
            Console.WriteLine($"{ido.Days} nap {ido.Hours} óra {ido.Minutes} perc");

            Console.WriteLine($"{idoosszes/24/60} nap {idoosszes%(24*60)/60} ora {idoosszes%60} perc");




            Console.ReadLine();
     
        }
    }
}
