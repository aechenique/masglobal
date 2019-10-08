namespace Test.Business
{
    using Test.Infrastructure;

    public class MonthlyEmployee : Employee
    {
        #region Fields

        public override decimal annualSalary => _employeeBase.monthlySalary * 12;

        #endregion Fields

        #region Constructors

        public MonthlyEmployee(IEmployeeBase employeeBase)
            : base(employeeBase)
        {
        }

        #endregion Constructors
    }
}