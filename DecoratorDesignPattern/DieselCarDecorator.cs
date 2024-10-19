using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    public class DieselCarDecorator : CarDecorator
    {
    //    private readonly ICar car;

        public DieselCarDecorator(ICar car) : base(car)
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
                BMWCar.Engine = "Diesel Engine";
                Console.WriteLine("DieselCarDecorator added Diesel Engine to the car : " + car);
            }
        }
    }
}
