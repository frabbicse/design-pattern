using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Design_Pattern
{
    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeesArray);
    }
}
