using System;

namespace Plane_ENG
{
    public class Circle : Plane
    {
        private int radius;
       
        public Circle(int radius)
        {
            this.radius = radius;
            this.Name = "Kör";
        }

        public override double Area()
        {
            return radius * radius * Math.PI;
        }
    }
}