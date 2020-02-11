using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentStrategy.Shop
{
    class Item
    {
        public String upCode { get; }
        public int price { get; }

        public Item(String upCode, int cost)
        {
            this.upCode = upCode;
            this.price = cost;
        }
    }
}
