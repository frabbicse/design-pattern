using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Example_2
{
   public interface IMobilePhone
    {
        INormalPhone GetNormalPhone();
        ISmartPhone GetSmartPhone() ;
    }
}
