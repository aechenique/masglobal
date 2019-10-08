namespace Test.Business
{
    using Test.Infrastructure;

    public abstract class Employee : IEmployee
    {
        #region Fields

        protected IEmployeeBase _employeeBase;

        #endregion Fields

        #region Constructors

        public Employee(IEmployeeBase employeeBase)
        {
            _employeeBase = employeeBase;
        }

        #endregion Constructors

        #region Properties

        public abstract decimal annualSalary
        {
            get;
        }

        public string contractTypeName
        {
            get => _employeeBase.contractTypeName; set => _employeeBase.contractTypeName = value;
        }

        public decimal hourlySalary
        {
            get => _employeeBase.hourlySalary; set => _employeeBase.hourlySalary = value;
        }

        public int id
        {
            get => _employeeBase.id; set => _employeeBase.id = value;
        }

        public decimal monthlySalary
        {
            get => _employeeBase.monthlySalary; set => _employeeBase.monthlySalary = value;
        }

        public string name
        {
            get => _employeeBase.name; set => _employeeBase.name = value;
        }

        public string roleDescription
        {
            get => _employeeBase.roleDescription; set => _employeeBase.roleDescription = value;
        }

        public int roleId
        {
            get => _employeeBase.roleId; set => _employeeBase.roleId = value;
        }

        public string roleName
        {
            get => _employeeBase.roleName; set => _employeeBase.roleName = value;
        }

        #endregion Properties
    }
}