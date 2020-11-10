using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektumok
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. AZONOSÍTHATÓSÁG
            var sikidomok1 = new Sikidom();
            var sikidomok2 = new Sikidom();

            //EL TUDJUK DÖNTENI, HOGY A KÉT PÉDÁNY AZONOS-E?
            //a két példányra mutató referencia van a két változóbn
            //a vizsgálat azt nézi hogy a két referenia ugyan oda mutat-e
            //alap esetben a tartalmát nem ellenőrzi.
            if (sikidomok1==sikidomok2)
            {
                Console.WriteLine("A két édány azonos");
            }
            else
            {
                Console.WriteLine("A két pédány NEM azonos");
            }

            //2. ÁLLAPOT VIZSGÁLATA

            //2.1 mező
            sikidomok1.OldalakSzama = 3;
            sikidomok1.OldalakSzama = 5;


            //2.2 property
            //ha a private get akkor nem fordítható le!!!
            //Console.WriteLine(sikidomok1.Data3);
            sikidomok1.Name = "SIKIDOMOK"; //setter függvényt hívjuk meg
            Console.WriteLine(sikidomok1.Name); //getter hívjuk meg

            //3.VISELKEDÉS

            //3.1 a függvény sziganatúra
            sikidomok1.Show(85,5);


            //3.2 A függvények paraméter átadása
            //érték szerinti átadás
            var ertek = 2;
            Console.WriteLine($"\nertek {ertek} ");
            sikidomok1.Show(ertek);
            Console.WriteLine($"ertek {ertek} ");


            //referencia szerinti átadás
            var referencia = new ReferenciaTipus() {ertek=3 };
            Console.WriteLine($"\nReferencia: {referencia.ertek}");
            sikidomok1.Show(referencia);
            Console.WriteLine($"Referencia: {referencia.ertek}");

            //érték típus referencia szerinti átadás

            var ertek2 = 4;
            Console.WriteLine($"\nertek2 {ertek2} ");
            sikidomok1.Show(ref ertek2);
            Console.WriteLine($"ertek2 {ertek2} ");

            //out csak kifelé ad paramétert vagy értéket
            int ertek3;
            //sikidomok1.ShowOut(out int ertek3); // VS 2015-től tuti hogy működik így is 
            sikidomok1.ShowOut(out ertek3);
            Console.WriteLine($"\nÉrték3: {ertek3} ");



            //kicsit másként azaz egyben az egész!!!!! de ugan az a menete
            Console.WriteLine();
            referencia = new ReferenciaTipus() { ertek = 3 };
            ertek2 = 4;
            Console.WriteLine($"ertek {ertek} Referencia: {referencia.ertek} Érték2: {ertek2} Érték3: {ertek3}");
            sikidomok1.Show(ertek, referencia,ref ertek2, out ertek3);
            Console.WriteLine($"ertek {ertek} Referencia: {referencia.ertek} Érték2: {ertek2} Érték3: {ertek3}");


            //függvények paramétereinek alapértelezett érték adása
            sikidomok1.Show(); //figyelem! ha nem adok meg paramétert akkor ezt fogja hívni
            sikidomok1.Show(width:9, name:"Akármi");//ebben az esetben nem kell magadni a height paramétert 
            //a fordíto megtalálja, mert van alapértelmezetten megadott értéke


            Console.ReadLine();
        }
    }
}
