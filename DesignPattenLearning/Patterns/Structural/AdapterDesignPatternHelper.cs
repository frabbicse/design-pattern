﻿using Adapter_Design_Pattern;

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattenLearning.Patterns.Structural
{
   public class AdapterDesignPatternHelper
    {
        public static void GetOutput()
        {
            string[,] employeesArray = new string[5, 4]
            {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
            };

            ITarget target = new EmployeeAdapter();
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            target.ProcessCompanySalary(employeesArray);
            Console.Read();
        }
    }
}
