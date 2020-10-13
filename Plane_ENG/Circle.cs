using System;

namespace Plane_ENG
{
    public class Circle : IPlane
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return radius * radius * Math.PI;
        }
    }
}