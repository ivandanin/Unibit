using System;
using System.Collections.Generic;
using System.Text;

namespace ПаркингСистема
{
    class Assistant
    {
        private IDictionary<string, Parking> parkings;

        public Assistant()
        {
            this.parkings = new Dictionary<string, Parking>();
        }

        public bool ParkVehicle(Vehicle vehicle)
        {
            foreach (var (_, parking) in this.parkings)
            {
                if (parking.ParkVehicle(vehicle))
                {
                    return true;
                }
            }

            return false;
        }

        public void AddParking(string name, int carCap, int busCap, int truckCap)
        {
            if (!this.parkings.ContainsKey(name))
            {
                this.parkings.Add(name, new Parking(name, carCap, busCap, truckCap));
            }
        }

        public string PrintParkedVehicles(string parkingName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format(Outputs.ParkedVehiclesMsg, parkingName));
            foreach (Vehicle vehicle in this.parkings[parkingName].GetVehicles())
            {
                sb.AppendLine(string.Format(Outputs.MakeModelMsg, vehicle.Make, vehicle.Model));
            }

            return sb.ToString().Trim('\r', '\n');
        }

        public string PrintParkingStatus()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var (name, parking) in this.parkings)
            {
                sb.AppendLine(string.Format(Outputs.ParkingStatusMsg, name));
                sb.AppendLine(string.Format(Outputs.LightVehiclesMsg, parking.CarCapacity, parking.CarUsedSpaces));
                sb.AppendLine(string.Format(Outputs.MediumVehiclesMsg, parking.BusCapacity,
                    parking.BusUsedSpaces));
                sb.AppendLine(string.Format(Outputs.HeavyVehiclesMsg, parking.TruckCapacity,
                    parking.TruckUsedSpaces));
            }

            return sb.ToString().Trim('\r', '\n');
        }
    }
}
