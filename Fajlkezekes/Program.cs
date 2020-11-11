using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fajlkezekes
{
    class Program
    {
        static void Main(string[] args)
        {
            //stream használat, stream olvasása ciklussal, nem stuktúrált adatok beolvasása
            var fajlnev = "teszt.txt"; //megadom a fájl elétési útját relatív hivatkozással, és egy változóban tárolom
            var fs = new FileStream(fajlnev, FileMode.Open);//megadom hogy a fájlt olvasásra megnyitom
            var sr = new StreamReader(fs, Encoding.UTF8);// megadom hogy olvasni fogom a fájlt

            while (!sr.EndOfStream)
            {
                var adat = sr.ReadLine();
                Console.WriteLine(adat);
            }            
            sr.Close();
            fs.Close();

            
            
            
            
            
            Console.ReadLine();


        }
    }
}
