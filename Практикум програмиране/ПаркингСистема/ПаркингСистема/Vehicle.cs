using System;
using System.Collections.Generic;
using System.Text;

namespace ПаркингСистема
{
    public interface Vehicle
    {
        public WeightClass WeightClass { get; }
        public string Make { get; set; }
        public string Model { get; set; }

    }
}
