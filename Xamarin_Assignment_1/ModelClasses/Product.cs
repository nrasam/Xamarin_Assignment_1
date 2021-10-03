using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_Assignment_1.ModelClasses
{
    public class Product
    {
        public string type { get; set; }
        public string imageURL { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
    public Product()
        {

        }

        public Product(string type, int quantity, double price)
        {
            this.type = type;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
