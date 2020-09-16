using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0909_hazi
{
    class Program
    {
        static void Main(string[] args)
        {
            //maga a program:
            Console.WriteLine("Melyik nap órarendjét szeretnéd látni?");
            var valasz = Console.ReadLine();
            Console.Clear();
           
            orarend_valasztos(valasz);

            Console.ReadLine();
        }

        private static void teszt()
        {
            Console.WriteLine("teszt függvény");
        }





        // függvények
        private static void orarend_valasztos(string valasz)
        {
            if (valasz.ToLower() == "Hétfő".ToLower())
            {
                hetfofugg();
            }
            else
            {
                if (valasz.ToLower() == "Kedd".ToLower())
                {
                    keddfugg();
                }
                else
                {
                    if (valasz.ToLower() == "Szerda".ToLower())
                    {
                        szerdafugg();
                    }
                    else
                    {
                        if (valasz.ToLower() == "Csütörtök".ToLower())
                        {
                            csutortokfugg();
                        }
                        else
                        {
                            if (valasz.ToLower() == "Péntek".ToLower())
                            {
                                pentekfugg();
                            }
                            else
                            {
                                Console.WriteLine("A hétvégén nincs óra!");
                            }
                        }
                    }
                }
            }
        }

        public static void hetfofugg()
        {
            //hétfő
            Console.WriteLine("A Hétfői órák a következők:");
            Console.WriteLine("1. Matek");
            Console.WriteLine("2. Töri");
            Console.WriteLine("3. Tesi");
            Console.WriteLine("4. Tesi");
            Console.WriteLine("5. Födrajz");
            Console.WriteLine("6. Kémia");
        }

        private static void keddfugg()
        {
            //kedd
            Console.WriteLine("A Keddi órák a következők:");
            Console.WriteLine("1. Angol");
            Console.WriteLine("2. Töri");
            Console.WriteLine("3. Matek");
            Console.WriteLine("4. Matek");
            Console.WriteLine("5. Födrajz");
            Console.WriteLine("6. Német");
        }

        private static void szerdafugg()
        {
            //szerda
            Console.WriteLine("A Szerdai órák a következők:");
            Console.WriteLine("1. Német");
            Console.WriteLine("2. Töri");
            Console.WriteLine("3. Irodalom");
            Console.WriteLine("4. Nyelvtan");
            Console.WriteLine("5. Födrajz");
            Console.WriteLine("6. Kémia");
        }

        
        private static void csutortokfugg()
        {
            //csütörtök
            Console.WriteLine("A Csütörtöki órák a következők:");
            Console.WriteLine("1. Informatika");
            Console.WriteLine("2. Angol");
            Console.WriteLine("3. Tesi");
            Console.WriteLine("4. Biológia");
            Console.WriteLine("5. Födrajz");
            Console.WriteLine("6. Kémia");
        }

        
        private static void pentekfugg()
        {
            //péntek
            Console.WriteLine("A Pénteki órák a következők:");
            Console.WriteLine("1. Informatika");
            Console.WriteLine("2. Angol");
            Console.WriteLine("3. Angol");
            Console.WriteLine("4. Tesi");
            Console.WriteLine("5. Födrajz");
            Console.WriteLine("6. Biológia");
        }
    }
}
