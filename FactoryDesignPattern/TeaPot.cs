namespace FactoryDesignPattern
{
    internal class TeaPot : DrinkPot
    {
        public int GetDrinkValue()
        {
            return 10;
        }

        public int GetPotLimit()
        {
            return 5;
        }

        public string GetPotType()
        {
            return "Tea Pot";
        }
    }
}