using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
   public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }

    public interface DrinkPot
    {
        string GetPotType();
        int GetPotLimit();
        int GetDrinkValue();
    }
}
