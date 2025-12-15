using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class EmployeeDecorator : Employee
    {
        protected Employee decoratedEmployee { get; set; }

        public EmployeeDecorator(Employee employee)
        {
            decoratedEmployee = employee;

            Name = employee.Name;
            BaseSalary = employee.BaseSalary;
            BankService = employee.BankService;
        }

        public override string GetInfo()
        {
            return decoratedEmployee.GetInfo();
        }

        public override double CalculateSalary()
        {
            return decoratedEmployee.CalculateSalary();
        }
    }
}
