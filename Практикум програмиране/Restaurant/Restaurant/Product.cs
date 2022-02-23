using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Restaurant
{
    public class Product
    {
        private string name;
        private decimal price;
        private int weight;

        public Unit Unit { get; set; }

        public string Name
        {
            get => this.name;
            set
            {
                if (!Regex.IsMatch(value, "^[а-яА-Я ]*$"))
                {
                    throw new Exception();
                }
                this.name = value;
            }
        }
        public decimal Price
        {
            get => this.price;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception();
                }
                this.price = value;
            }
        }
        public int Weight
        {
            get => this.weight;
            set
            {
                if (value < 0 || value > 1000)
                {
                    throw new Exception();
                }
                this.weight = value;
            }
        }
    }
}
