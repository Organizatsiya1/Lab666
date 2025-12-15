using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class IntermediateEnglishSertificate:EmployeeDecorator
    {
        public string ExaminationTitle {  get; set; }
        public int YearOfSertificate {  get; set; }

        public IntermediateEnglishSertificate(Employee employee) : base(employee) { }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Знание английского (Сертификат: {ExaminationTitle}, Год: {YearOfSertificate})";
        }
    }
}
