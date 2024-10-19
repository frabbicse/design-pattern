using FacadeDesignPattern;

using System;

namespace DesignPattenLearning.Patterns.Structural
{
    public  class FacadeDesignPatternHelper
    {
        public static void GetOutput()
        {
            Order order = new Order();
            order.PlaceOrder();
            Console.Read();
        }
    }
}
