using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
   public abstract class AnimalFactory
    {
        public abstract Animal GetAnimal(string AnimalType);

        public static AnimalFactory CreateAnimalFactory(string factoryType)
        {
            if(factoryType.Equals("Sea"))
            {
                return new SeaAnimalFactory();
            }
            else
            {
                return new LandAnimalFactory();
            }
        }
    }
}
