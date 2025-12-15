namespace Model
{
    public abstract class EmployeeDecorator : Employee
    {
        protected Employee decoratorEmployee { get; set; }

        public EmployeeDecorator(Employee employee)
        {
            decoratorEmployee = employee;

            Name = employee.Name;
            BaseSalary = employee.BaseSalary;
            BankService = employee.BankService;
        }

        public override string GetInfo()
        {
            return decoratorEmployee.GetInfo();
        }

        public override double CalculateSalary()
        {
            return decoratorEmployee.CalculateSalary();
        }
    }
}
