using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Design_Pattern
{
  public  class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> listEmployee)
        {
            foreach(Employee employee in listEmployee)
            {
                Console.WriteLine("Tk " + employee.Salary + " Salary Credited to " + employee.Name + " Account ");
            }
        }
    }
}
