using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    // равностранен
    public class EquialateralTriangle : IosescelesTriangle
    {
        public EquialateralTriangle(double a, double b, double c) : base(a, b, c)
        {
        }

        public override Double calculatePerimeter()
        {
            return base.calculatePerimeter();
        }

        public override void getFigure()
        {
            Console.WriteLine("Равностранен триъгълник");
        }
    }
}
