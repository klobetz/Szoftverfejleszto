using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ertektipusok
{
    class Program
    {
        static void Main(string[] args)
        {
            //értéktpus
            var ertek1 = 10;
            var ertek2 = ertek1;
            Console.WriteLine($"Érék1: {ertek1}, Érték2: {ertek2}");
            //Érék1: 10, Érték2: 10

            ertek1 = 20;
            Console.WriteLine($"Érék1: {ertek1}, Érték2: {ertek2}");
            //Érék1: 20, Érték2: 10
                       
            
            
            
            //referencia típus
            var referencia1 = new Sajatreferencia();
            referencia1.ertek = 10;
            var referencia2 = referencia1;

            Console.WriteLine($"\nReferencia1: {referencia1.ertek}, Referencia2: {referencia2.ertek}");
            //Referencia1: 10, Referencia2: 10
            
            referencia1.ertek = 20;
            Console.WriteLine($"Referencia1: {referencia1.ertek}, Referencia2: {referencia2.ertek}");
            //Referencia1: 20, Referencia2: 20

            

            //összetett beépített adattípusok
            var tomb1 = new int[] { 10 };
            var tomb2 = tomb1;
            Console.WriteLine($"\ntomb1: {tomb1[0]} és a tomb2: {tomb2[0]}");

            tomb1[0] = 20;
            Console.WriteLine($"tomb1: {tomb1[0]} és a tomb2: {tomb2[0]}");


            //karakterekből álló tömb
            var szoveg1 = new string(new char[] { '1', '0'}); //a karakterekből álló tömböt belecsomagoljk egy stringbe
            var szoveg2 = szoveg1;
            //var szoveg2 ="10"
            Console.WriteLine($"\nszöveg1: {szoveg1} és a szöveg2: {szoveg2}");

            szoveg1 = "20";
            Console.WriteLine($"szöveg1: {szoveg1} és a szöveg2: {szoveg2}");



            Console.ReadLine();
        }
    }
}
