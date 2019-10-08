namespace Test.Infrastructure
{
    public interface IEmployee : IEmployeeBase
    {
        #region Properties

        decimal annualSalary
        {
            get;
        }

        #endregion Properties
    }
}