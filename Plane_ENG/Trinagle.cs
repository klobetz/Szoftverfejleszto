using System;

namespace Plane_ENG
{
    public class Trinagle : IPlane
    {
        private int basic;
        private int height;

        public Trinagle(int basic, int height)
        {
            this.basic = basic;
            this.height = height;
        }

        public double Area()
        {
            return (basic * height) / 2;
        }
    }
}