using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    public class Square : Rectangle
    {
        public Square(double a, double b) : base(a, b)
        {
        }

        public override double calculatePerimeter()
        {
            return base.calculatePerimeter();
        }

        public override void getFigure()
        {
            Console.WriteLine("Квадрат");
        }
    }
}
