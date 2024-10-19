namespace FactoryDesignPattern
{
    internal class CoffeePot : DrinkPot
    {
        public int GetDrinkValue()
        {
            return 100;   
        }

        public int GetPotLimit()
        {
            return 10;
        }

        public string GetPotType()
        {
            return "Coffee pot";
        }
    }
}