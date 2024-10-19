using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Example_2.Concrete_Class
{
  public  class Samsung : IMobilePhone
    {
        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}
