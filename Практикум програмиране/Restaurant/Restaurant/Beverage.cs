using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Beverage : Product
    {
        private double CaloriesMultiply = 1.5;

        public Beverage()
        {
            this.Unit = Unit.MILLILITERS;
        }

        public double Calories => this.Weight * CaloriesMultiply;
    }
}
