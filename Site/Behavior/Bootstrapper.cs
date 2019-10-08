namespace Site.Behavior
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;
    using System.IO;
    using System.Reflection;

    using Test.Infrastructure;

    public class Bootstrapper
    {
        #region Fields

        [Import]
        public IEmployeeProvider EmployeeProvider;

        #endregion Fields

        #region Constructors

        static Bootstrapper()
        {
            Instance = new Bootstrapper();
            Instance.Run();
        }

        #endregion Constructors

        #region Properties

        public static Bootstrapper Instance
        {
            get;
            private set;
        }

        #endregion Properties

        #region Methods

        private void Run()
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new AssemblyCatalog(this.GetType().Assembly));

            var pluginsPath = AppDomain.CurrentDomain.BaseDirectory;
            var files = new List<string>(Directory.GetFiles(pluginsPath, "*.Module.dll"));

            pluginsPath = Path.Combine(pluginsPath, "bin");
            if (Directory.Exists(pluginsPath))
                files.AddRange(Directory.GetFiles(pluginsPath, "*.Module.dll"));

            foreach (var file in files)
            {
                var asm = Assembly.LoadFrom(file);
                catalog.Catalogs.Add(new AssemblyCatalog(asm));
            }

            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }

        #endregion Methods
    }
}