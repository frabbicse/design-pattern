using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public class MoneyBack : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "Money back";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }
    }
}
