using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    public class PetrolCarDecorator : CarDecorator
    {
        public PetrolCarDecorator(ICar car) : base(car)
        {
        }

        public override ICar ManufacturereCar()
        {
            car.ManufacturereCar();
            AddEngine(car);
            return car;
        }

        public void AddEngine(ICar car)
        {
            if(car is BMWCar)
            {
                BMWCar BMWCar = (BMWCar)car;
                BMWCar.Engine = "Petrol Engine";
                Console.WriteLine("PetrolCarDecorator added petrol Engine to the Car : " + car);
            }
        }
    }
}
