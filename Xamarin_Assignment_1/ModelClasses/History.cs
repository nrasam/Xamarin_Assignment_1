using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_Assignment_1.ModelClasses
{
    public class History
    {
        public string name { set; get; }
        public int quantity { set; get; }
        public double totalPrice { set; get; }

        public DateTime purchaseTime { set; get; }
        public History(string name, int quantity, double totalPrice, DateTime purchaseTime)
        {
            this.name = name;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
            this.purchaseTime = purchaseTime;
        }
    }
}
