using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentStrategy.Strategie
{
    interface Bezahlungsstrategie
    {
        public void pay(int amount);
    }
}
