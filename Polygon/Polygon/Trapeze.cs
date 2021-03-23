using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    class Trapeze : Quadrilateral
    {
        public Trapeze(double a, double b, double c) : base(a, b, c)
        {
        }

        public override double calculatePerimeter()
        {
            return getA() + getB() + (getC() * 2);
        }

        public override void getFigure()
        {
            Console.WriteLine("Трапец");
        }
    }
}
