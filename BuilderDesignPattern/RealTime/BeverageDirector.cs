using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern.RealTime
{
   public class BeverageDirector
    {
        public Beverage MakeBeverage(BeverageBuilder beverageBuilder)
        {
            beverageBuilder.CreateBeverage();

            beverageBuilder.SetBeverageType();
            beverageBuilder.SetWater();
            beverageBuilder.SetMilk();
            beverageBuilder.SetSugar();
            beverageBuilder.SetPowderQuantity();

            return beverageBuilder.GetBeverage();
        }
    }
}
