using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_valogatas
{    
    class Program
    {
        static void Main(string[] args)
        {
            var valogatas = new Valogatas();
            
            var szam = valogatas.Bekeres();

            var list = valogatas.Feltolt(szam);

            Console.WriteLine($"A list elemeinek a száma: {string.Join(", ", list)}");

            List<int> paros, paratlan;
            valogatas.Vizsgalat(list, out paros, out paratlan);

            Console.WriteLine($"\na páros lista elemeinek a száma: {paros.Count} \n\nAz elemek értékei: { string.Join(", ", paros)}");

            Console.WriteLine($"\na páratlan lista elemeinem a száma: {paratlan.Count} \n\nAz elemek értékei: {string.Join(", ", paratlan)}");

            Console.ReadLine();
        }
    }
}
