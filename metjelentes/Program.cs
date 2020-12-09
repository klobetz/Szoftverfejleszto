using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metjelentes
{
    class Program
    {
        static void Main(string[] args)
        {
            //var adatFelepites = new Adatfelepites();
            
                var adatLista = new List<Adatfelepites>();
                var fajlNev = "tavirathu13.txt";
                using (var fs = new FileStream(fajlNev, FileMode.Open))
                {
                    using (var sr = new StreamReader(fs, Encoding.UTF8))
                    {
                        while (!sr.EndOfStream)
                        {
                            var sor = sr.ReadLine();
                            string[] darabol = sor.Split(' ');
                            var adatFelepites = new Adatfelepites();
                            adatFelepites.Telepules = darabol[0];
                            adatFelepites.Ido = darabol[1];
                            adatFelepites.Szelirany = darabol[2];
                            adatFelepites.Homerseklet = Convert.ToUInt32(darabol[3]);
                            adatLista.Add(adatFelepites);
                        }
                    }
                }

            

                //2.feladat
                Console.WriteLine("2.feladat:");
            Console.Write("Kérem adja meg a város kódját: ");
            var valasz = Console.ReadLine();

            var eredmeny = adatLista.LastOrDefault(adat => adat.Telepules.Contains(valasz.ToUpper())); //ez csak egyet talál meg
            if (eredmeny != null)
            {
                Console.WriteLine($"Az utolsó adat a településről: {eredmeny.Ido.Substring(0, 2)}:{eredmeny.Ido.Substring(2, 2)} ");
                Console.WriteLine($"Az utolsó adat a településről: {eredmeny.Ido.Substring(0).Insert(2, ":")} "); //ez egy kicsit rövidebb
            }
            else
            {
                Console.WriteLine("Nincs ilyen eredmény");
            }

            //3.feladat
            Console.WriteLine("\n3.feladat");
            var min = adatLista.Min(adat => adat.Homerseklet);
            //var min2 = adatLista.Select(adat => adat.Homerseklet).Min();
            var eredmenyMin = adatLista.First(adat => adat.Homerseklet == min);
            Console.WriteLine($"A min kiíratása\nA település: {eredmenyMin.Telepules}\na mérés ideje: {eredmenyMin.Ido.Insert(2, ":")}\na mért hőmérséklet: {eredmenyMin.Homerseklet} Celsius");

            var max = adatLista.Max(adat => adat.Homerseklet);
            var eredmenyMax = adatLista.First(adat => adat.Homerseklet == max);
            Console.WriteLine($"\nA max kiíratása\nA települész: {eredmenyMax.Telepules}\nA mérés ideje: {eredmenyMax.Ido.Insert(2,":")}\nA mért hőmérséklet: {eredmenyMax.Homerseklet} Celsius");

            //4.feladat
            Console.WriteLine("4. feladat");
            var szelcsend = adatLista.Where(adat => adat.Szelirany == "00000");
            foreach (var item in szelcsend)
            {
                Console.WriteLine($"A szélcsendes város: {item.Telepules}, a mérés ideje: {item.Ido.Insert(2,":")}");
            }
            if (!szelcsend.Any())
            {
                Console.WriteLine("Nem volt szélcsend a mérések idején.");
            }

            //5.feladat
            Console.WriteLine("5.feladat");
            var csoprotositas = adatLista.GroupBy(adat => adat.Telepules);
            foreach (var elem in csoprotositas)
            {
                //Console.Write(elem.Key+ " ");
                List<Adatfelepites> adatokIdoSzerint = elem.Where(adat => adat.Ido.Substring(0,2) == "01" || adat.Ido.Substring(0,2) == "07" || adat.Ido.Substring(0, 2) == "13" || adat.Ido.Substring(0, 2) == "19").ToList();
                //Console.Write(adatokIdoSzerint.Count+ " \n");
                var ingadozas = elem.Max(adat => adat.Homerseklet) - elem.Min(adat => adat.Homerseklet);

                if (adatokIdoSzerint.GroupBy(adat => adat.Ido.Substring(0,2)).Count() < 4)
                    Console.WriteLine($"{elem.Key} NA, Hőmérséklet ingadozás: {ingadozas}");
                else
                    Console.WriteLine($"{elem.Key} Középhőmérséklete: {Math.Round(adatokIdoSzerint.Average(adat => adat.Homerseklet))}, Hőingadozás: {ingadozas}");
            }

            //6.feladat
            Console.WriteLine("\n6.feladat" );
            //var mentes = @"c:\teszt\";
            var varosSzerintCsoportosit = adatLista.GroupBy(adat => adat.Telepules);
            foreach (var varos in varosSzerintCsoportosit)
            {
                //Console.WriteLine(varos.Key);
                using (var fs = new FileStream(varos.Key+ ".txt", FileMode.Create))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(varos.Key);
                        foreach (var adat in adatLista)
                        {
                            if (adat.Telepules.Equals(varos.Key))
                            {
                                var szelero = Convert.ToInt32(adat.Szelirany.Substring(3, 2));
                                sw.Write($"{adat.Ido.Insert(2,":")} ");
                                for (int i = 1; i <= szelero; i++)
                                {
                                    sw.Write("#");                                   
                                }
                                sw.WriteLine();
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Az adatok írása elkészült!");            
            Console.ReadLine();
        }
    }
}