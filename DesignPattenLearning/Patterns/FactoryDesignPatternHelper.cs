using FactoryDesignPattern;

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattenLearning.Patterns
{
  public class FactoryDesignPatternHelper
    {
        public static void GetFactoryOutput()
        {
            //CreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

            //if (cardDetails != null)
            //{
            //    Console.WriteLine("CardType : " + cardDetails.GetCardType());
            //    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
            //    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            //}
            //else
            //{
            //    Console.Write("Invalid Card Type");
            //}
            //Console.ReadLine();



            DrinkPot pot= DrinkPotFactory.GetDrinkPot("Coffee");

            if (pot != null)
            {
                Console.WriteLine("Pot Type : " + pot.GetPotType());
                Console.WriteLine("Pot Limit : " + pot.GetPotLimit());
                Console.WriteLine("POt Value :" + pot.GetDrinkValue());
            }
            else
            {
                Console.Write("Invalid Pot Type");
            }
            Console.ReadLine();
        }
    }
}
