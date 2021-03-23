using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    public class Right_AngledTriangle : Triangle
    {
        //правоъгълен
        public Right_AngledTriangle(double a, double b, double c) : base(a, b, c)
        {
        }

        public override Double calculatePerimeter()
        {
            return base.calculatePerimeter();
        }

        public override void getFigure()
        {
            Console.WriteLine("Правоъгълен триъгълник"); 
        }
    }
}
