using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_kulcsszo_bajaro_minta
{
    class Program
    {   /// <summary>
        /// statikus és az osztályszintű függvények használata
        /// - statikus osztálynak csak statikus függvényei lehetnek
        /// - nem statikus osztálynak lehet nem statikus függvénye, tulajdonsága, mezői
        /// - statikus függvényből csak staikus függvényt tudok hívni és hivatkozni
        /// - példányszintűből viszont példányszintűt és statikust is tudok hívni és hivatkozni
        /// 
        ///  statikus kulcsszóval használt tulajdonságok (property) mező (Field) függvény (method) az osztály definícióhoz tartozik
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            foreach (var item in sorozatLista())
            {
                Console.WriteLine(item);
            }

            //statikus függvény statikus függvényből hívható
            //sorozatLista();EZ lefut mert statik csak egy van belőle

            //példányszintű függvény
            //PeldanyFuggveny();  // ez nem hívható hiszen nem tudjuk melyiket szeretnénk meghívni, akármennyi lehet belőle


            Console.ReadLine(); 
        }
        //bejáró minta
        private static IEnumerable<string> sorozatLista()
        {
            yield return "valami1";
            yield return "valami2";
            yield return "valami3";
            yield return "valami4";

            //sorozatLista();// ezek minden további nélül lefut
            //Main(new string[] { });

            //PeldanyFuggveny(); //ez nem fut le hiba!! ennek szüsége van egy példányra hogy meg tudjuk hívni
        }
        public void PeldanyFuggveny()
        {
            //statikus függvényhívás
            //sorozatLista();  //ezek minden tovbbi probléma nélkül lefut
            //Main(new string[] { });

            //példányszintű függvényből hívhatok példányszintűt, mert ezen a példányon bellülit jelenti
            //PeldanyFuggveny("akármi");
        }

        public void PeldanyFuggveny(string sort)
        {
            //sorozatLista();
            //Main(new string[] { });
            //PeldanyFuggveny();

        }
    }
}
