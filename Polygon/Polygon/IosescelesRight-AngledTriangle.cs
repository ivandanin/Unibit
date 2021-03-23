using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    public class IosescelesRight_AngledTriangle : Right_AngledTriangle
    {
        //правоъгълен равнобедрен
        public IosescelesRight_AngledTriangle(double a, double b, double c) : base(a, b, c)
        {
        }

        public override Double calculatePerimeter()
        {
            return base.calculatePerimeter();
        }

        public override void getFigure()
        {
            Console.WriteLine("Равнобедрен правоъгълен триъгълник");
        }
    }
}
