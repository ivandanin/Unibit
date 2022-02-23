using System.Collections.Generic;

namespace Restaurant
{
    public class Orders
    {
        public Orders()
        {
            this.Products = new List<Product>();
        }
        public int NumberOfTable { get; internal set; }
        public List<Product> Products { get; internal set; }
    }
}