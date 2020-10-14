using System;

namespace Plane_ENG
{
    public class Square : Plane
    {
        private int sidelenght;

        public Square(int sidelenght)
        {
            this.sidelenght = sidelenght;
            this.Name = "Négyzet";
        }

        public override double Area()
        {
            return sidelenght * sidelenght;
        }
    }
}