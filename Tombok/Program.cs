using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            //tömb deklarálása
            //int[] tomb10 = new int[10];
            //char[] tomb1 = new char[] { 'e', '2' };
            //var tomb4 = new int[10];
            var tomb = new int[] { 16, 2, 82, 5, 95 };

            Console.WriteLine($"A tömb hossza: {tomb.Length}"); //Tömb hossza
            Console.WriteLine($"A tömb utolsó eleme: {tomb[tomb.Length-1]}"); //tömb utolsó eleme
            Console.WriteLine($"A tömb 3. eleme: {tomb[2]}"); //tömb x-dik eleme

           
            //a tömb elemeinek a kiíratása
            foreach (var item in tomb)
            {
                Console.WriteLine($"a tömb elemei: {item}");
            }
            //kicsit szebben
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine($"a tömb {i}. eleme: {tomb[i]}");
            }

            var tomb2 = new int[100];
            var r = new Random();

            for (var i = 0; i < 50; i++)
            {
                tomb2[i] = r.Next(1, 100);
                Console.WriteLine($"A tömb {i}. eleme {tomb2[i]}") ;
            }
            //r.next(1, 100);


            Console.ReadLine();
        }
    }
}
