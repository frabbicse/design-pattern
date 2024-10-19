namespace FactoryDesignPattern
{
    internal class ColdDrink : DrinkPot
    {
        public int GetDrinkValue()
        {
            return 50;
        }

        public int GetPotLimit()
        {
            return 600;
        }

        public string GetPotType()
        {
            return "Cold drinks";
        }
    }
}