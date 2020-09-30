using System;

namespace Ermehamistas
{
    public class Erme
    {
        public Erme()
        {
            Console.WriteLine("erme konstruktor");
        }
        
        Random r = new Random();

        public virtual int feldobas()
        {
            Console.Write("erme.feldobas()");
            return r.Next(0,2); //ez itt nem lehet 1-es mert a felső értéket nem éri el! ezért "2"
        }
    }
}