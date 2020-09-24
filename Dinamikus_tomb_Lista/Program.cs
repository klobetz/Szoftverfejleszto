using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinamikus_tomb_Lista
{
    class Program
    {
        static void Main(string[] args)

        {   //Lista feltöltése véletlen számmal
            var r = new Random();
            var list = new List<int>();

            for (int i = 0; i <1500; i++)
            {
                list.Add(r.Next(1,100));
                Console.WriteLine($"A tömb {i+1}. eleme:{list[i]}"); //ha az elem számát is szeretnéd megjeleníteni
                                                                    //akkor a fo cikluson bellül kell elhelyezned
            }

            //kiíratás sima

            //foreach (var item in list)
            //{
            //    Console.WriteLine($"A tömb elemei:{item}");
            //}



            Console.ReadLine();
        }
    }
}
