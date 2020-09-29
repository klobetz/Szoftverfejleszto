using System;
using System.Runtime.CompilerServices;

namespace sikidomok_osztaly_fuggveny
{
    /// <summary>
    /// ez azért jtt létre így mert (var negyzet = new Negyzet(oldalhossz: 4)) igy deklaráltuk a fő programban
    /// </summary>
    public class Negyzet : ISikidomok //trejött az osztály
    {
        private int oldalhossz;

        public Negyzet(int oldalhossz) //konstruktor függvény: az a föggvény ami minden létrehozéskor lefut.
                                       //Nincs visszatérési értéke hiszen a visszatérési értéke az az osztálypéldány
        {
            this.oldalhossz = oldalhossz;
        }

        //itt létrejött a terület föggvény internal cere public-ra object cere int mert egész számot hívunk static töröl
        public int Terulet()
        {
            //visszatérési érték: a return utasítással
            //return this.oldalhossz * this.oldalhossz;
            //helyett ezt is használhatod ebben az esetben nem kell a this
            //szó hiszen az osztályon belllül látja a változót és nem a paraméterre gondol
            return oldalhossz * oldalhossz;
        }   
    }
}