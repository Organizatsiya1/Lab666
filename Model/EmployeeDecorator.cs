using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmployeeDecorator : Employee
    {
        protected Employee employee { get; set; } //тута либо интерфейс делать работника либо поменять название 

        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public IBankService BankService { get; set; }


        public EmployeeDecorator(Employee employee)
        {
            Employee = employee;

            Name = employee.Name;
            BaseSalary = employee.BaseSalary;
            BankService = employee.BankService;
        }

        public virtual string GetInfo()
        {
            return Employee.GetInfo();
        }

        public virtual double CalculateSalary()
        {
            return Employee.CalculateSalary();
        }
    }
}
