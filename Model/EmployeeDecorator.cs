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
