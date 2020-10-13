using System;

namespace Plane_ENG
{
    public class Square :IPlane
    {
        private int sidelenght;

        public Square(int sidelenght)
        {
            this.sidelenght = sidelenght;
        }

        public double Area()
        {
            return sidelenght * sidelenght;
        }
    }
}