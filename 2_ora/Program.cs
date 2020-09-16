using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ora
{
    class Program
    {
            /// <summary>
            /// feltétel vizsgálata
            /// ha szerda van 
            /// akkor írja ki a husleves receptet 
            /// különben a túróstészta receptet írasuk ki
            /// </summary>
            /// <param name="args"></param>
            
        static void Main(string[] args)
        {

            /* if(feltétel kerül)
                     {
                         húsleves
                     }
                     else
                     {
                         turostészta
                     } */

            

            //vátozók angolul variable röviden: var 
            //határozzuk meg a mai napot!
            var maidatum = DateTime.Today;
            var mainap = maidatum.DayOfWeek;
            var mavanhusleves = DayOfWeek.Wednesday;

            //if (DateTime.Today.DayOfWeek==DayOfWeek.Wednesday)
            if (mainap == mavanhusleves)
                {   //húsleves recept
                    Console.WriteLine("víz");
                    Console.WriteLine("hús");
                    Console.WriteLine("répa");
                    Console.WriteLine("hagyma");
                    Console.WriteLine("fokhagyma");
                }
            else
                {   //túróstészta recept
                    Console.WriteLine("víz");
                    Console.WriteLine("tészta");
                    Console.WriteLine("túró");
                    Console.WriteLine("tejföl");
                    Console.WriteLine("szalonna");
                }
            
            

            Console.ReadLine();
            
        }
    }
}
