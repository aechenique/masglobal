namespace Test.Business
{
    using Test.Infrastructure;

    public static class EmployeeFactory
    {
        #region Methods

        public static IEmployee GetInstance(IEmployeeBase employeeBase)
        {
            return employeeBase.contractTypeName == "HourlySalaryEmployee"
                ? (IEmployee)new HourlyEmployee(employeeBase)
                : (IEmployee)new MonthlyEmployee(employeeBase);
        }

        #endregion Methods
    }
}