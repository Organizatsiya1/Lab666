using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IBankService
    {
        string Name {  get; set; }
        double CalculateSalary(double basesalary);
    }
}
