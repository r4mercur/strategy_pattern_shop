using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentStrategy.Strategie
{
    class CreditCardStrategy : Bezahlungsstrategie
    {
        private String name, cardNumber, dateOfExpiry;

        public CreditCardStrategy(String name, String cardNumber, String dateOfExpiry)
        {
            this.name = name;
            this.cardNumber = cardNumber;
            this.dateOfExpiry = dateOfExpiry;
        }

        public void pay(int amount)
        {
            Console.WriteLine(amount + " paid with credit card");
        }
    }
}
