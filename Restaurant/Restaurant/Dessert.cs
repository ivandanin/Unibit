using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Dessert : Product
    {
        private double CaloriesMultiply = 3;

        public Dessert()
        {
            this.Unit = Unit.GRAMS;
        }

        public double Calories => this.Weight * CaloriesMultiply;
    }
}
