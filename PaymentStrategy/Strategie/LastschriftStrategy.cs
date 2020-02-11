using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentStrategy.Strategie
{
    class LastschriftStrategy : Bezahlungsstrategie
    {
        private String name, street, plz, iban;

        public LastschriftStrategy(String name, String street, String plz, String iban)
        {
            this.name = name;
            this.street = street;
            this.plz = plz;
            this.iban = iban;
        }

        public void pay(int amount)
        {
            Console.WriteLine(amount + "paid with lastschrift");
        }
    }
}
