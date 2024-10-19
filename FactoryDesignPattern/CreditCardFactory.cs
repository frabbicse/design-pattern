 
namespace FactoryDesignPattern
{
  public  class CreditCardFactory
    {
        public static CreditCard GetCreditCard(string cardType)
        {
            CreditCard cardDetails = null;

            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            return cardDetails;

        }
        
    }


    public class DrinkPotFactory
    {

        public static DrinkPot GetDrinkPot(string potType)
        {
            DrinkPot objPot = null;

            if (potType == "Coffee")
            {
                objPot = new CoffeePot();
            }
            else if(potType == "Tea")
            {
                objPot = new TeaPot();
            }
            else if(potType == "Cold Drinks")
            {
                objPot = new ColdDrink();
            }

            return objPot;

        }
        
    }
}
