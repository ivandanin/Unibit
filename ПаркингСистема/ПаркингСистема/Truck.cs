using System;
using System.Collections.Generic;
using System.Text;

namespace ПаркингСистема
{
    public class Truck : Vehicle
    {
        public Truck()
        {
            this.WeightClass = WeightClass.HEAVY;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public WeightClass WeightClass { get; private set; }
    }
}
