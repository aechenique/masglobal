namespace Test.Business
{
    using Test.Infrastructure;

    public class HourlyEmployee : Employee
    {
        #region Fields

        public override decimal annualSalary => 120 * _employeeBase.hourlySalary * 12;

        #endregion Fields

        #region Constructors

        public HourlyEmployee(IEmployeeBase employeeBase)
            : base(employeeBase)
        {
        }

        #endregion Constructors
    }
}