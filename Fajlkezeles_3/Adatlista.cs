using System.Collections.Generic;

namespace Fajlkezeles_3
{
    public class Adatlista
    {
        public Adatlista()
        {
            Adat = new List<Adatfelepites>();
        }

        public List<Adatfelepites> Adat { get; set; }
    }
}