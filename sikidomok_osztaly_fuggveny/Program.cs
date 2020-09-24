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



            //ugyanez szebben!



            Console.ReadLine();
        }

    }
}
