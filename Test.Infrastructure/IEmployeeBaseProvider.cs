namespace Test.Infrastructure
{
    using System.Collections.Generic;

    public interface IEmployeeBaseProvider
    {
        #region Methods

        IEnumerable<IEmployeeBase> GetEmployeeBaseList(int? id = null);

        #endregion Methods
    }
}