using FactoryMethodDesignPattern;

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattenLearning.Patterns
{
   public class FactoryMethodDesignPatternHelper
    {
       public static void GetFactoryMethodOutPut()
        {
            CreditCard creditCard = new TitaniumFactory().CreateProduct();

            if(creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            Console.WriteLine("\n");

            creditCard = new MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
