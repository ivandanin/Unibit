using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    public abstract class Quadrilateral : Figure
    {
        private double a;
        private double b;
        private double c;
        
        protected Quadrilateral(double a, double b) 
        {
            this.a = a;
            this.b = b;        
        }
        protected Quadrilateral(double a, double b, double c) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
            ;
        }

        public override double calculatePerimeter()
        {
            return 2 * (a + b);
        }
        public double getA()
        {
            return a;
        }
        public double getB()
        {
            return b;
        }
        public double getC()
        {
            return c;
        }

        public override void getFigure()
        {
        }
    }
}
