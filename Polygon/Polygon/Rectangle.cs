using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    //квадрат
    public class Rectangle : Parallelogram
    {
        public Rectangle(double a, double b) : base(a, b)
        {
        }

        public override double calculatePerimeter()
        {
            return base.calculatePerimeter();
        }

        public override void getFigure()
        {
            Console.WriteLine("Правоъгълник");
        }
    }
}
