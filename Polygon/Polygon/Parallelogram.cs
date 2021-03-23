using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    //успоредник
    public class Parallelogram : Quadrilateral
    {
        public Parallelogram(double a, double b) : base(a, b)
        {
        }


        public override double calculatePerimeter()
        {
            return base.calculatePerimeter();
        }

        public override void getFigure()
        {
            Console.WriteLine("Успоредник");
        }
    }
}
