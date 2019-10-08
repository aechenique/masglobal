namespace Test.Business
{
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Linq;

    using Test.Infrastructure;

    [Export(typeof(IEmployeeProvider))]
    public class EmployeeProvider : IEmployeeProvider
    {
        #region Properties

        [Import]
        private IEmployeeBaseProvider BaseProvider;

        #endregion Properties

        #region Methods

        public IEnumerable<IEmployee> GetEmployeeList(int? id = null)
        {
            return BaseProvider.GetEmployeeBaseList(id).Select(e => EmployeeFactory.GetInstance(e));
        }

        #endregion Methods
    }
}