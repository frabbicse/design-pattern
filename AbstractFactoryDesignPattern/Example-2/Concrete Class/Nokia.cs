using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Example_2.Concrete_Class
{
   public class Nokia : IMobilePhone
    {
        public INormalPhone GetNormalPhone()
        {
            return new Nokia1600();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new NokiaPixel();
        }

        
    }
}
