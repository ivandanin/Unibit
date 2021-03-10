using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    public class Assistant
    {

        private IDictionary<string, Product> menu;
        private IDictionary<int, List<Orders>> tables;
        private decimal money = 0;
        private int sales = 0;

        public Assistant()
        {
            this.menu = new Dictionary<string, Product>();
            this.tables = new Dictionary<int, List<Orders>>();
        }

        public void AddProduct(Product product)
        {
           if (this.menu.ContainsKey(product.Name))
            {
                this.menu.Add(product.Name, product);
            
            } else
            {
                this.menu[product.Name] = product;
            }
        }

        public void Order(Orders order)
        {
            if (this.tables.ContainsKey(order.NumberOfTable))
            {
                this.tables[order.NumberOfTable].Add(order);

            } else
            {
                this.tables.Add(order.NumberOfTable, new List<Orders> {order});
            }

            this.money += order.Products.Select(p => p.Price).Sum();
            this.sales += order.Products.Count;
        }
        public string PrintStatus()
        {
            if (this.tables.Count == 0)
            {
                return Message.NoSales;
            }
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format(Message.TotalTablesMsg, this.tables.Count));
            output.AppendLine(string.Format(Message.TotalSales, this.sales, this.money));
            output.AppendLine(Message.ByCategory);

            var tup = (1, 4m);
            tup.Item1 += 2;
            tup.Item2 += 5;

            Dictionary<string, (int count, decimal price)> grouped = new Dictionary<string, (int count, decimal price)>();
            foreach (var table in tables)
            {
                foreach (Orders order in table.Value)
                {
                    foreach (Product product in order.Products)
                    {
                        var category = product switch
                        {
                            Salad _ => "Салата",
                            Soup _ => "Супа",
                            MainDish _ => "Основно ястие",
                            Dessert _ => "Десерт",
                            Beverage _ => "Напитка",
                            _ => "No Category"
                        };

                        if (grouped.ContainsKey(category))
                        {
                            var newCount = grouped[category].count + 1;
                            var newPrice = grouped[category].price + product.Price;
                            grouped[category] = (newCount, newPrice);
                        }
                        else
                        {
                            grouped.Add(category, (1, product.Price));

                        }
                    }
                }
            }
            foreach (var entry in grouped)
            {
                output.AppendLine($"  -  {entry.Key}: {entry.Value.count} - {entry.Value.price:F2}");
            }
            return output.ToString().Trim('\n', '\r');
        }
        public IDictionary<string, Product> Menu => this.menu;
    }
}