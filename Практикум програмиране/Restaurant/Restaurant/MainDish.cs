using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class MainDish : Product
    {
        private double CaloriesMultiply = 1;
       
        public MainDish()
        {
            this.Unit = Unit.GRAMS;
        }
        public double Calories => this.Weight * CaloriesMultiply;
    }
}
