using System;

namespace Plane_ENG
{
    public class Trinagle : Plane
    {
        private int basic;
        private int height;

        public Trinagle(int basic, int height)
        {
            this.basic = basic;
            this.height = height;
            this.Name = "Háromszög";
        }

        public override double Area()
        {
            return (basic * height) / 2;
        }
    }
}