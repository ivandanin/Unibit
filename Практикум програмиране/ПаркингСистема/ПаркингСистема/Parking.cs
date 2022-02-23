using System;
using System.Collections.Generic;
using System.Linq;


namespace ПаркингСистема
{
    class Parking : Park
    {
        private string parkingsName;
        private int carCapacity;
        private int carUsedSpaces;
        private int busCapacity;
        private int busUsedSpaces;
        private int truckCapacity;
        private int truckUsedSpaces;
        private ICollection<Vehicle> vehicles;

        public Parking(string parkingsName, int carCapacity, int busCapacity, int truckCapacity)
        {
            this.parkingsName = parkingsName;
            this.carCapacity = carCapacity;
            this.busCapacity = busCapacity;
            this.truckCapacity = truckCapacity;

            this.vehicles = new List<Vehicle>();
        }
        public int CarCapacity => this.carCapacity;
        public int BusCapacity => this.busCapacity;
        public int TruckCapacity => this.truckCapacity;
        public int CarFreeSpaces => this.carUsedSpaces;
        public int BusFreeSpaces => this.busUsedSpaces;
        public int TruckFreeSpaces => this.truckUsedSpaces;


        public string Name { get; set; }

        public int CarUsedSpaces => this.carUsedSpaces;

        public int BusUsedSpaces => this.busUsedSpaces;

        public int TruckUsedSpaces => this.truckUsedSpaces;

        public bool ParkVehicle(Vehicle vehicle)
        {
            switch (vehicle)
            {
                case Car car:
                    if (this.carCapacity == this.carUsedSpaces)
                        return false;
                        this.carUsedSpaces++;
                    break;
                case Bus bus:
                    if (this.busUsedSpaces == this.busCapacity)
                        return false;
                        this.busUsedSpaces++;
                    break;
                case Truck truck:
                    if (this.truckUsedSpaces == this.truckCapacity)
                        return false;
                        this.truckUsedSpaces++;
                    break;
                default:
                    throw new NotImplementedException();
            }
            this.vehicles.Add(vehicle);
            return true;
        }
        public List<Vehicle> GetVehicles()
        {
            return this.vehicles.OrderBy(vehicle => vehicle.WeightClass).ToList();
        }

        public bool park(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
