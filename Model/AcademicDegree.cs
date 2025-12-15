using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AcademicDegree:EmployeeDecorator
    {
        public string DissertationTitle {  get; set; }
        public int Year {  get; set; }
        public string ScienceArea {  get; set; }

        public AcademicDegree(Employee employee) : base(employee) { }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Ученая степень (Диссертация: {DissertationTitle}, Год: {Year}, Область: {ScienceArea})";
        }
    }
}
