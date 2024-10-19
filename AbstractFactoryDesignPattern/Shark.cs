using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class Shark : Animal
    {
        public string Speak()
        {
            return "Can not speak";
        }
    }
}
