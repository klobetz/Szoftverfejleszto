using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatul_tesztelos_ciklus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hány órakkor kelsz fel?");
            
            string valasz; //Itt kell deklarálni a változót különben nem ismeri a (While) 
            int szam;

            do
            {//ez a kódblokk ismétlődik
                Console.WriteLine("Hány órakkor kelsz fel?");
                valasz = Console.ReadLine();
                
            }while (!int.TryParse(valasz, out szam));
            Console.WriteLine($"sikerült a átalakítás te minden nap {valasz}");
            
            Console.ReadLine();
            
        }
    }
}
