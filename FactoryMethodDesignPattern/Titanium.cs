using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public class Titanium : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 15000;
        }

        public string GetCardType()
        {
            return "Titanium Edge";
        }

        public int GetCreditLimit()
        {
            return 1500;
        }
    }
}
