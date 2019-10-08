namespace Test.Infrastructure
{
    public interface IEmployeeBase
    {
        #region Properties

        string contractTypeName
        {
            get; set;
        }

        decimal hourlySalary
        {
            get; set;
        }

        int id
        {
            get; set;
        }

        decimal monthlySalary
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