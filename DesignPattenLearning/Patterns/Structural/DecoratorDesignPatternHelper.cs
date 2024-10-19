using DecoratorDesignPattern;

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattenLearning.Patterns.Structural
{
   public  class DecoratorDesignPatternHelper
    {
        public static void GetOutput()
        {
            ICar bmwCar1 = new BMWCar();
            bmwCar1.ManufacturereCar();
            Console.WriteLine(bmwCar1 + "\n");
            DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
            carWithDieselEngine.ManufacturereCar();
            Console.WriteLine();
            ICar bmwCar2 = new BMWCar();
            PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
            carWithPetrolEngine.ManufacturereCar();
            Console.ReadKey();
        }
    }
}
