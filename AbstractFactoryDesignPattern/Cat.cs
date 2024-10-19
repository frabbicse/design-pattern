using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class Cat : Animal
    {
        public string Speak()
        {
            return "Meow Meow Meow";
        }
    }
}
