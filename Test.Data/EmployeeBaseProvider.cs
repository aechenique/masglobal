namespace Test.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Web.Script.Serialization;

    using Test.Infrastructure;

    [Export(typeof(IEmployeeBaseProvider))]
    public class EmployeeBaseProvider : IEmployeeBaseProvider
    {
        #region Fields

        private static EmployeeBase[] _all;

        #endregion Fields

        #region Constructors

        static EmployeeBaseProvider()
        {
            try { LoadData(); }
            catch { _all = new EmployeeBase[0]; }
        }

        #endregion Constructors

        #region Methods

        public IEnumerable<IEmployeeBase> GetEmployeeBaseList(int? id = null)
        {
            if (id.HasValue)
            {
                var result = _all.FirstOrDefault(e => e.id == id);
                if (result == null)
                    return new EmployeeBase[0];

                return new EmployeeBase[] { result };
            }

            return _all;
        }

        private static void LoadData()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Test.Data.employees.json";
            var serializer = new JavaScriptSerializer { MaxJsonLength = int.MaxValue };

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                var source = reader.ReadToEnd();
                _all = serializer.Deserialize<EmployeeBase[]>(source);
            }
        }

        #endregion Methods
    }
}