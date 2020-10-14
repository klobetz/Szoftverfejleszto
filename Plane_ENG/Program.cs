using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plane_ENG
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(sidelenght: 5);
            Console.WriteLine($"A négyzet területe: {square.Area()} m2");

            var circle = new Circle(radius: 6);
            Console.WriteLine($"A kör területe: {circle.Area()} m2");

            var triangle = new Trinagle(basic: 6, height: 5);
            Console.WriteLine($"A Háromszög területe: {triangle.Area()} m2");

            var planes = new List<Plane>();

            planes.Add(square);
            planes.Add(circle);
            planes.Add(triangle);

            Console.WriteLine($"A síkidomok területe: {planes.Sum(x=>x.Area())} m2");

            //nem lehet példányosítani
            //var valami = new Plane();

            Console.WriteLine();

            foreach (var item in planes)
            {
                Console.WriteLine($"A síkidom neve: {item.Name} a síkidom területe: {item.Area()}");
            }
 
            Console.ReadLine();
        }
    }
}
