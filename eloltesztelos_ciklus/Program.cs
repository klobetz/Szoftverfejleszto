using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eloltesztelos_ciklus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hány gombócot ettél meg?");
            var valasz = Console.ReadLine();

            int szam;
            
            while (!int.TryParse(valasz, out szam)) //A "!" jellel tagadjuk meg a feltételt
            {//ez a kódblokk ismétlődik
                Console.WriteLine("nem sikerült az átalakítás!");
                valasz = Console.ReadLine();
            }
            Console.WriteLine($"Sikerült az átalakítás tehát {szam} gombócot ettél meg");
            Console.ReadLine();
        }
    }
}
