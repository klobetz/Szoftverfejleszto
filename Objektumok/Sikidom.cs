using System;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Objektumok
{
    public class Sikidom
    {
        public Sikidom()
        {
        }
        //2. ÁLLAPOT VIZSGÁLATA
        //két tulajdonság: Mező és a property
        private int SzogekSzama;

        //2.1 Mező
        //ez úgy viselkedik mint egy változó, mindenki által elérhető
        //kívülről is elérhetők: írható és olvasható, használatuk nem javasolt nem korlátozható
        public int OldalakSzama;

        //2.2 Property (tulajdonság) alapértelmezettem mint a mező
        public int Csucsok { get; set; }
        //public string Name { get; set; }

        //azonban a fordító egy ilyen kóddá alaktja át, külön veszi az írást és az olvasást 
        //backing field ez tartalmazza a property értékét
        private int _Csucsok;

        // ez a getter függvény visszaadja a backing field értékét
        public int Csucsok_GET()
        {
            return _Csucsok;
        }

        //ez a setter függvény ami arra való hogy írjuk vele a backing field-et
        public void Csucsok_SET(int value)
        {
            _Csucsok = value;
        }


        //2.2.1. Ezekből következik: külön tudjunk csak írható éa csak olvasható propertyt létrehozni
        //csak olvasható property
        public int Data1 { get; }

        //csak írható property itt implementálnom kell mert csak így férek hozzá a bejövő adatokhoz
        //a deffiníció szerint a bejövő paraméter alapértelemetten neve: "value" 
        //típusa pedig mindig a property típusa
        private int _data2; //nekem kell létrehozni a backing field-et
        public int Data2 { set { _data2 = value; } }

        //2.2.2 Külön tudjuk a láthatóságát is szabályozni
        //olvasni csak osztályon bellül, írni pedig kívülről és bellülről is
        public int Data3 { private get; set; }
        //olvasni bárhonnan írni viszont csak osztályon bellül
        public int Data4 { get; private set; }
       
        //2.2.3 Saját magam implemenálom 
        private string _name;
        public string Name 
        {
            get 
            {
                //tetszőleges művelet
                return _name;
            }
            set
            {
                //tetszőleges művelet
                _name = value;
            }
        }

        //3. VISELKEDÉS
        //a viselkedést függvényeken keresztül szabályozzuk
        //a függvény neve és a paramétere jelenti a függvény szignatúráját
        //a szignatúrát a függvények paraméterlistája jelenti


        //3.1 a függvény sziganatúra azonos függvénynév
        //függvény overloading-nak hívják ezt a technológiát
        public void Show()
        {

        }

        //nem a név hanem a szignatúra (név+paraméterek) azonosítja a függvényt
        //uyganolyan névvel tudok létrehozni több függvényt ha a szignatúrájuk különmözik
        public void Show(bool disable) //paramétertípus
        {

        }

        public void Show(int posx, int posy) //az x és y irányú pozíció
        {

        }

        //public void Show(int x, int y) //A paraméternév nem a szignatúra része ezét et nem különbözik
        //{

        //}


        //a visszatérési érték sem a szignatúra része
        //public int Show()
        //{
        //    return 0;
        //}


        //3.2 A függvények paraméter átadása

        //érték szerinti áradás
        public void Show(int height)
        {
            Console.WriteLine($"Show height: {height} ");
            height = height * 2;
            //először elvégzi a műveletet a két bal oldali érték között majd átadja az értéket
            // +=, -=, *=, /=
            //height *= 2;            
            Console.WriteLine($"Show height: {height} ");
        }

        //referencia szerinti átadás
        public void Show(ReferenciaTipus referencia)
        {
            Console.WriteLine($"Show referencia: {referencia.ertek}");           
            //először elvégzi a műveletet a két bal oldali érték között majd átadja az értéket
            // +=, -=, *=, /=            
            referencia.ertek *= 2;
            Console.WriteLine($"Show referencia: {referencia.ertek}");
        }

        //érték típus referencia szerinti átadás
        //ha értéktípust szeretnék referenciatípusként átadni akkor a REF kulcsszót kell használnom!
        public void Show(ref int width)
        {
            Console.WriteLine($"Show width: {width} ");

            //először elvégzi a műveletet a két bal oldali érték között majd átadja az értéket
            // +=, -=, *=, /=  
            width *= 2;
            Console.WriteLine($"Show width: {width} ");
        }

        //out paraméter itt mindenképpen kell értéket adni az out-két deffiniált paraméternek
        public void ShowOut(out int ertek3)
        {
            //out paraméter itt mindenképpen kell értéket adni az out-két deffiniált paraméternek
            ertek3 = 10;
        }



        //kicsit másként azaz egyben az egész!!!!! de ugan az a menete
        public void Show(int height, ReferenciaTipus referencia, ref int width, out int ertek3)
        {
            Console.WriteLine($"Show height: {height} Show referencia: {referencia.ertek} Width: {width} ");            
            ertek3 = 10;               
            height = height * 2;
            //először elvégzi a műveletet a két bal oldali érték között majd átadja az értéket
            // +=, -=, *=, /=
            //height *= 2;
            referencia.ertek *= 2;
            width *= 2;

            Console.WriteLine($"Show height: {height} Show referencia: {referencia.ertek} Width: {width} Érték3: {ertek3}");
        }

    }
}