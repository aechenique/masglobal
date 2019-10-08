namespace Test.Infrastructure
{
    public interface IEmployee : IEmployeeBase
    {
        #region Properties

        int annualSalary
        {
            get;
        }

        #endregion Properties
    }
}