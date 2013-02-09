namespace TimeKeeper.Configs
{
    using System.Configuration;
    using CJR.Common;
    using Microsoft.Practices.ServiceLocation;
    using Nancy.ViewEngines;
    using Nancy.ViewEngines.Razor;
    using ReadAThonEntry.Mappers;
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
                                             x.AddRegistry(new CJR.Persistence.configs.CjrPersistenceRegistry(ConfigurationManager.AppSettings["TestMode"] != "0",false, "ReadAThonEntry",false));
                                         });
            ServiceLocator.SetLocatorProvider(() => new StructureMapServiceLocator(ObjectFactory.Container));
        }
    }
}