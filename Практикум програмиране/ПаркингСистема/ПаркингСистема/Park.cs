using System;
using System.Collections.Generic;
using System.Text;

namespace ПаркингСистема
{
    interface Park
    {
        public bool park(Vehicle vehicle);
        public List<Vehicle> GetVehicles();


        public int CarCapacity { get; }
        public int BusCapacity { get; }
        public int TruckCapacity { get; }
        public int CarUsedSpaces { get; }
        public int BusUsedSpaces { get; }
        public int TruckUsedSpaces { get; }
    }
}
