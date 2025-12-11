using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Sberbank: IBankService
    {
        public Sberbank() 
        {
            Name = "Сбербан";
            Comission = 1.0;
        }
        public string Name { get; set; }
        private double Comission;
        public double CalculateSalary(double basesalary)
        {
            return (basesalary * (1 - (Comission / 100)));
        }
    }
}
