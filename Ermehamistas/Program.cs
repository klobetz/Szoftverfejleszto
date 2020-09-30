using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ermehamistas
{
    class Program
    {
        static void Main(string[] args)
        {
            var erme = new HamisErme(); //létrejött az osztály
            //var erme = (Erme)(new HamisErme());
            //Erme erme = new HamisErme();
            
            CsinaldFeldobas(erme);

            Console.ReadLine();

        }

        private static void CsinaldFeldobas(Erme erme)
        {
            Console.WriteLine($"Az érmefeldobás eredménye:");
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"{erme.feldobas()}, ");
            }
        }
    }
}
