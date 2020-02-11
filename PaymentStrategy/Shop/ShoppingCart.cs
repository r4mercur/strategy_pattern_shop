using PaymentStrategy.Strategie;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentStrategy.Shop
{
    class ShoppingCart
    {
        List<Item> items;

        public ShoppingCart()
        {
            this.items = new List<Item>();
        }

        public void addItem(Item item)
        {
            this.items.Add(item);
        }

        public void removeItem(Item item)
        {
            this.items.Remove(item);
        }

        public int calculateTotal()
        {
            int sum = 0;
            foreach(Item item in items) {
                sum += item.price;
            }
            return sum;
        }

        // Strategie
        public void Pay(Bezahlungsstrategie paymentStrategy)
        {
            int amount = calculateTotal();
            paymentStrategy.pay(amount);
        }
    }
}
