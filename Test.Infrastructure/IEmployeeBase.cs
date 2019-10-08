namespace Test.Infrastructure
{
    public interface IEmployeeBase
    {
        #region Properties

        string contractTypeName
        {
            get; set;
        }

        int hourlySalary
        {
            get; set;
        }

        int id
        {
            get; set;
        }

        int monthlySalary
        {
            get; set;
        }

        string name
        {
            get; set;
        }

        string roleDescription
        {
            get; set;
        }

        int roleId
        {
            get; set;
        }

        string roleName
        {
            get; set;
        }

        #endregion Properties
    }
}