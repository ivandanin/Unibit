using System;
using System.Collections.Generic;
using System.Text;

namespace Магазин_за_авточасти
{
    public class Part
    {
        private string name;
        private string code;
        private PartCategory category;
        private HashSet<Car> supportedCars;
        private double buyPrice;
        private double sellPrice;
        private Manufacturer manufacturer;

        public Part(string name, double buyPrice, double sellPrice, Manufacturer manufacturer, string code, PartCategory category)
        {
            this.name = name;
            this.buyPrice = buyPrice;
            this.sellPrice = sellPrice;
            this.manufacturer = manufacturer;
            this.code = code;
            this.category = category;
            this.supportedCars = new HashSet<Car>();
        }

        public void AddSupportedCar(Car car) => this.supportedCars.Add(car);

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"Part: {this.name} \n");
            result.Append($"-code: {this.code} \n");
            result.Append($"-category: {this.category} \n");
            result.Append($"-buyPrice: {this.buyPrice} \n");
            result.Append($"-sellPrice: {this.sellPrice} \n");
            result.Append($"-manufacturer: {this.manufacturer} \n");
            result.Append($"---Supported cars--- \n");
            foreach (var car in this.supportedCars)
            {
                result.Append($"{car} \n");
            }
            result.Append("----------------------\n");

            return result.ToString();
        }
        
    }
}
