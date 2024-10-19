using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class Dog : Animal
    {
        public string Speak()
        {
            return "Bark Bark";
        }
    }
}
