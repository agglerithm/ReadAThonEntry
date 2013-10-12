using NHibernate.Context;
using ReadAThonEntry.Core.DTOs;

namespace ReadAThonEntry.Configs
{
    using System.Configuration;
    using CJR.Persistence.configs;
    using Core.Configs;
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
                                             x.AddRegistry(new  CjrPersistenceRegistry<StudentDto,WebSessionContext>(ConfigurationManager.AppSettings["TestMode"] != "0",
                                                 false,"ReadAThonEntry.Core"));
                                             x.AddRegistry(new ReadAThonCoreRegistry());
                                         }); 
        }
    }
}