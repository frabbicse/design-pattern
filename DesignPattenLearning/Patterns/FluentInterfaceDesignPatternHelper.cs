using FluentInterfaceDesignPattern;

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattenLearning.Patterns
{
   public class FluentInterfaceDesignPatternHelper
    {
       public static void GetOutput()
        {
            FluentEmployee obj = new FluentEmployee();

            obj.NameOfTheEmployee("Fazle Rabbi")
                .Born("04/09/1988")
                .WorkingOn("Software Development")
                .StayAt("Mirpur, Dhaka");

            Console.Read();
        }
    }
}
