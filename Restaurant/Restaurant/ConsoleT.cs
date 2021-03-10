using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class ConsoleT : Terminal
    {
        private Dictionary<string, Type> productsType = new Dictionary<string, Type>
        {
            {"салата", typeof(Salad)},
            {"супа", typeof(Soup)},
            {"основно ястие", typeof(MainDish)},
            {"десерт", typeof(Dessert)},
            {"напитка", typeof(Beverage)}
        };

        private Assistant assistant;
        private bool isRunning;

        public ConsoleT(Assistant assistant)
        {
            this.assistant = assistant;
            this.isRunning = false;
        }



        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string message, params string[] parameters)
        {
            Console.WriteLine(message, parameters);
        }

        public void Start()
        {
            this.isRunning = true;
            while (this.isRunning)
            {
                this.ReadCommand();
            }

        }
        private void ReadCommand()
        {
            string[] tokens = this.ReadLine().Split(",");
            string command = tokens[0];

            switch (command)
            {
                case "салата":
                case "супа":
                case "основно ястие":
                case "десерт":
                case "напитка":

                    Product product = this.CreateProduct(command, tokens);
                    this.assistant.AddProduct(product);
                    break;

                case "продажби":
                    this.WriteLine(this.assistant.PrintStatus());
                    break;

                case { } tableNum when int.TryParse(command, out _)
                    && int.Parse(command) > 0
                    && int.Parse(command) <= 30:

                    Orders order = this.CreateOrder(tableNum, tokens);
                    this.assistant.Order(order);
                    break;

                case "изход":
                    this.WriteLine(this.assistant.PrintStatus());
                    this.isRunning = false;
                    break;
            }
        }
        private Orders CreateOrder(string tableNum, string[] tokens)
        {
            Orders order = new Orders();
            order.NumberOfTable = int.Parse(tableNum);

            for (int i = 1; i < tokens.Length; i++)
            {
                string productsName = tokens[i].Trim();

                if (this.assistant.Menu.ContainsKey(productsName))
                {
                    order.Products.Add(this.assistant.Menu[productsName]);
                }
            }

            if (order.Products.Count == 0)
            {
                throw new Exception();
            }
            return order;
        }

        private Product CreateProduct(string command, string[] tokens)
        {
            if (tokens.Length != 4)

                throw new Exception();

            var products = this.productsType[command];
            var prod = Activator.CreateInstance(products) as Product;
            string name = tokens[1].Trim();


            if (!int.TryParse(tokens[2], out var size))

                throw new Exception();


            if (!decimal.TryParse(tokens[3], out var price))

                throw new Exception();

            prod.Name = name;
            int weight = 0;
            prod.Weight = weight;
            prod.Price = price;

            return prod;

        }
 
    }
}
