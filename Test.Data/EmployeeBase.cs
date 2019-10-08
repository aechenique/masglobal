namespace Test.Data
{
    using Test.Infrastructure;

    public class EmployeeBase : IEmployeeBase
    {
        #region Properties

        public string contractTypeName
        {
            get; set;
        }

        public int hourlySalary
        {
            get; set;
        }

        public int id
        {
            get; set;
        }

        public int monthlySalary
        {
            get; set;
        }

        public string name
        {
            get; set;
        }

        public string roleDescription
        {
            get; set;
        }

        public int roleId
        {
            get; set;
        }

        public string roleName
        {
            get; set;
        }

        #endregion Properties
    }
}