using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fajlkezeles_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fajlnev = "teszt.txt";
            using (var fs = new FileStream(fajlnev, FileMode.Open))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        var adat = sr.ReadLine();
                        Console.WriteLine(sr);
                    }
                }
            }
        }
    }
}
