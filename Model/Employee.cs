using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public string Name {  get; set; }
        public double BaseSalary {  get; set; }
        public IBankService BankService {  get; set; }
        public virtual string GetInfo()
        {
            return GetType().Name;
        }
        public virtual double CalculateSalary()
        {

            if (BankService != null)
                return BankService.CalculateSalary(BaseSalary);
            return BaseSalary;
        }
    }
}
