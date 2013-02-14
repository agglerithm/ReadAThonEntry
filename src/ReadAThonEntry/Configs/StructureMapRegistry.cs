namespace ReadAThonEntry.Configs
{
    using System.Configuration;
    using CJR.Common;
    using CJR.Persistence.configs;
    using Core.Configs;
    using Microsoft.Practices.ServiceLocation;
    using Nancy.ViewEngines;
    using Nancy.ViewEngines.Razor;
    using StructureMap;
    using StructureMap.Configuration.DSL;

    public class StructureMapRegistry : Registry
    {
        public StructureMapRegistry()
        {
            For<IRazorConfiguration>().Use<DefaultRazorConfiguration>(); 
            For<IFileSystemReader>().Use<DefaultFileSystemReader>(); 
            For<IRazorConfiguration>().Use<CustomRazorConfiguration>();
            Scan(z =>
            {
                z.TheCallingAssembly();
                z.WithDefaultConventions();
            });

            //Scan(x =>
            //         {
            //             x.AssemblyContainingType<JsonModule>();
            //             x.WithDefaultConventions();
            //         });
        }
    }

    public static class StructureMapBootstrapper
    {
        public static void Execute()
        {
            ObjectFactory.Initialize(x =>
                                         { 
                                             x.AddRegistry(new StructureMapRegistry());
                                             x.AddRegistry(new  CjrPersistenceRegistry(ConfigurationManager.AppSettings["TestMode"] != "0",false, "ReadAThonEntry.Core",false));
                                             x.AddRegistry(new ReadAThonCoreRegistry());
                                         });
            ServiceLocator.SetLocatorProvider(() => new StructureMapServiceLocator(ObjectFactory.Container));
        }
    }
}