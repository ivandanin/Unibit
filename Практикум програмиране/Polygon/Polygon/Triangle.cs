using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    public abstract class Triangle : Figure
    {

    private Double a;
    private Double b;
    private Double c;

        protected Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override Double calculatePerimeter()
        {
            return Math.Round(a + b + c, 3);
        }

        public Double getA()
        {
            return a;
        }
        public Double getB()
        {
            return b;
        }
        public Double getc()
        {
            return c;
        }

        public override void getFigure()
        {
        }
    }
}
