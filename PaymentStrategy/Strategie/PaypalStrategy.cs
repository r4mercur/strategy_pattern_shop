using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentStrategy.Strategie
{
    class PaypalStrategy : Bezahlungsstrategie
    {
        private String email, password;

        public PaypalStrategy(String email, String password)
        {
            this.email = email;
            this.password = password;
        }

        public void pay(int amount)
        {
            Console.WriteLine(amount + " paid with paypal account");
        }
    }
}
