namespace PullReadAThonData.Configs
{
    using System.Configuration;
    using CJR.Common;
    using CJR.Persistence.configs;
    using CjrHttp.config;
    using Microsoft.Practices.ServiceLocation;
    using ReadAThonEntry.Core.Configs;
    using StructureMap;
    using StructureMap.Configuration.DSL;

    public class StructureMapRegistry : Registry
    {
        public StructureMapRegistry()
        { 
            Scan(z =>
            {
                z.TheCallingAssembly();
                z.WithDefaultConventions();
            });
 
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
                                             x.AddRegistry(new CjrHttpRegistry());
                                             x.AddRegistry(new ReadAThonCoreRegistry());
                                         });
            ServiceLocator.SetLocatorProvider(() => new StructureMapServiceLocator(ObjectFactory.Container));
        }
    }
}