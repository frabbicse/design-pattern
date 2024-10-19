using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Example_2
{
   public class MobileClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;

        public MobileClient(IMobilePhone factory)
        {
            smartPhone = factory.GetSmartPhone();
            normalPhone = factory.GetNormalPhone();
        }

        public string GetSmartPhoneModelDetails()
        {
            return smartPhone.GetModelDetails();
        }

        public string GetNormalPhoneModelDetails()
        {
            return normalPhone.GetModelDetails();
        }
    }
}
