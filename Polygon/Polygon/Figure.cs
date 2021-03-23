using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    public abstract class Figure
    {
        public Double perimeter;
        
        public abstract Double calculatePerimeter();
        public abstract void getFigure();
    }
}
