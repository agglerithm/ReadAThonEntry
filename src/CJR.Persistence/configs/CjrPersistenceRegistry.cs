
using System.Configuration;
using NHibernate.Context;

namespace CJR.Persistence.configs
{
    using FluentNHibernate;
    using StructureMap.Configuration.DSL;
    public class CjrPersistenceSessionBasedRegistry<T>
    {
        
    }
    public class CjrPersistenceRegistry<T,TSessionContext> : Registry where TSessionContext : ICurrentSessionContext
    {
        public CjrPersistenceRegistry(bool testMode, bool rebuildSchema, string assembly)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["entriesConnectionString"].ToString();
            //var connectionKey = testMode == false ? "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\entries.mdb" : "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\entries.mdb;";
            var createnewTables = testMode && rebuildSchema;

            For<ISessionSource>().Singleton().Use<CjrSessionSource<T, TSessionContext>>()
              .Ctor<string>("connectionKey").Is(connectionString) 
              .Ctor<bool>("createnewTables").Is(createnewTables);

            Scan(x =>
                     {
                         x.TheCallingAssembly();
                         x.WithDefaultConventions();
                     });
 
        }
    }
}