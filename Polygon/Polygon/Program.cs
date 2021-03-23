using System;

namespace Polygon
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Triangle iosTriangle = new IosescelesTriangle(4, 4, 2);

            Quadrilateral trapeze = new Trapeze(7, 8, 5);


            iosTriangle.getFigure();
            Console.WriteLine(iosTriangle.calculatePerimeter());

            trapeze.getFigure();
            Console.WriteLine(trapeze.calculatePerimeter());
            
            
        }
    }
}
