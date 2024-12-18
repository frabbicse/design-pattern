﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
   public abstract class CarDecorator : ICar
    {
        protected ICar car;
        public CarDecorator(ICar car) => this.car = car;

        public virtual ICar ManufacturereCar()
        {
            return car.ManufacturereCar();
        }
    }
}
