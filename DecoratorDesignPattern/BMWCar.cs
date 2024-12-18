﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    public class BMWCar : ICar
    {
        private string CarName = "BMW";
        public string CarBody { get; set; }
        public string CarDoor { get; set; }
        public string CarWheels { get; set; }
        public string CarGlass { get; set; }
        public string  Engine { get; set; }
        public override string ToString()
        {
            return "BMWCar [CarName = " + CarName + ", CarBody= "+ CarBody +", CarDoor = "+CarDoor+", CarWheels = "+CarWheels+", CarGlass = "+CarGlass+", Engine = "+Engine+" ]";
        }
        public ICar ManufacturereCar()
        {
            CarBody = "carbon fiber material ";
            CarDoor = "4 car doors";
            CarWheels = "4 MRF wheels";
            CarGlass = "6 car glasses";
            return this;
        }
    }
}
