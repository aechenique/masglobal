namespace Site.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using Site.Behavior;

    using Test.Infrastructure;

    public class EmployeesController : ApiController
    {
        #region Methods

        public IEnumerable<IEmployee> GetAllEmployees()
        {
            return Bootstrapper.Instance.EmployeeProvider.GetEmployeeList();
        }

        public IEnumerable<IEmployee> GetEmployee(int id)
        {
            return Bootstrapper.Instance.EmployeeProvider.GetEmployeeList(id);
        }

        #endregion Methods
    }
}