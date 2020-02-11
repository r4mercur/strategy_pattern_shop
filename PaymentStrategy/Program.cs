using PaymentStrategy.Shop;
using PaymentStrategy.Strategie;
using System;

namespace PaymentStrategy
{
    class Program
    {
        // Program Test
        static void Main(string[] args)
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            Item item1 = new Item("1234", 10);
            Item item2 = new Item("5678", 1000);

            shoppingCart.addItem(item1);
            shoppingCart.addItem(item2);

            // pay with paypal
            shoppingCart.Pay(new PaypalStrategy("test@email.de", "pass"));

            // pay with CreditCard
            shoppingCart.Pay(new CreditCardStrategy("mayer", "1232142", DateTime.Today.ToString()));
        }
    }
}
