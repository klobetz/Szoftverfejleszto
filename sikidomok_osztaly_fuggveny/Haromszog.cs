using System;

namespace sikidomok_osztaly_fuggveny
{
    public class Haromszog : ISikidomok
    {
        private int alap;
        private int magassag;

        public Haromszog(int alap, int magassag)
        {
            this.alap = alap;
            this.magassag = magassag;
        }

        public double Terulet()
        {
            return (alap*magassag)/2;
        }
    }
}