using System;

namespace sikidomok_osztaly_fuggveny
{
    public class Kor
    {
        private int sugar;

        public Kor(int sugar)
        {
            this.sugar = sugar;
        }

        public double Terulet()
        {
            return (sugar * sugar * Math.PI);
        }
    }
}