using System;
using System.Collections.Generic;
using System.Text;

namespace FluentInterfaceDesignPattern
{
   public class FluentEmployee
    {
        private Employee employee = new Employee();

        public FluentEmployee NameOfTheEmployee(string FullName)
        {
            employee.FullName = FullName;
            return this;
        }
        public FluentEmployee Born(string DOB)
        {
            employee.DOB= Convert.ToDateTime(DOB);
            return this;
        }
        public FluentEmployee WorkingOn(string Department)
        {
            employee.Department = Department;
            return this;
        }
        public FluentEmployee StayAt(string Address)
        {
            employee.Address = Address;
            return this;
        }
    }
}
