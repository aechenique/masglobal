namespace Test.Infrastructure
{
    using System.Collections.Generic;

    public interface IEmployeeProvider
    {
        #region Methods

        IEnumerable<IEmployee> GetEmployeeList(int? id = null);

        #endregion Methods
    }
}