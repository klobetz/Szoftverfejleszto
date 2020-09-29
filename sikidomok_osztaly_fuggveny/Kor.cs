using System;

namespace sikidomok_osztaly_fuggveny
{
    public class Kor : ISikidomok
    {
        private int sugar;

        public Kor(int sugar)
        {
            this.sugar = sugar;
        }

        public int Terulet()
        {
            return (int)(sugar * sugar * Math.PI);
        }
    }
}