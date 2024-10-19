namespace FactoryDesignPattern
{
    public class Platinum : CreditCard 
    {    
        public string GetCardType()
        {
            return "Platinum Plus";
        }

        public int GetCreditLimit()
        {
            return 350000;
        }

        public int GetAnnualCharge()
        {
            return 20000;
        }
    }
}
