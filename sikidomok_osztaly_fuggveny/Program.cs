using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidomok_osztaly_fuggveny
{
    class Program
    {/// <summary>
    /// Készítsünk egy olyan programot aminek a segítségével ki tudjuk számolni a különböző síkidomok területét.
    /// pl: négyzet, kör, háromszög...
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            //négyzet
            var negyzet = new Negyzet(oldalhossz: 4);
            Console.WriteLine($"A négyzet területe: {negyzet.Terulet()}"); //a négyzet területének a kiszámítása 
            
            //kör
            var kor = new Kor(sugar: 5);
            Console.WriteLine($"A kör területe: {kor.Terulet()}");

            //Háromszö
            var haromszog = new Haromszog(alap: 6, magassag: 5);
            Console.WriteLine($"A háromszög területe: {haromszog.Terulet()}");

            //adjuk össze a területeket
            //var teruletosszeg = negyzet.Terulet() + kor.Terulet() + haromszog.Terulet(); //így nincs hibaüzenet!(double)
            var teruletosszeg = negyzet.Terulet();
            teruletosszeg = teruletosszeg + kor.Terulet();
            teruletosszeg += haromszog.Terulet();

            Console.WriteLine($"A területek összege: {teruletosszeg} m2");

            
            
            
            
            //ugyanez szebben!

            //Azt néztük meg, hogy hogyan tudunk különböző osztályoknak bizonyos tulajdonságait közösíteni

            var sikidomLista = new List<ISikidomok>();

            sikidomLista.Add(negyzet);
            sikidomLista.Add(kor);
            sikidomLista.Add(haromszog);



            //var osszeg = 0;
            //foreach (var item in sikidomLista)
            //{
            //    osszeg += item.Terulet();
            //}
            //Console.WriteLine($"A területek összege máskép: {osszeg}");

            //var osszeg = sikidomLista.Sum(x=>x.Terulet());
            //Console.WriteLine($"A területek összege Linq-val: {osszeg} ");

            Console.WriteLine($"A területek összege Linq-val: {sikidomLista.Sum(x => x.Terulet())} ");






            Console.ReadLine();
        }

    }
}
