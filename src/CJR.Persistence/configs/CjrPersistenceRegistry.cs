
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

            var connectionKey = testMode == false ? "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bin\\entries.mdb" : "entriesTest.mdb";
            var createnewTables = testMode && rebuildSchema;

            For<ISessionSource>().Singleton().Use<CjrSessionSource<T,TSessionContext>>()
              .Ctor<string>("connectionKey").Is(connectionKey) 
              .Ctor<bool>("createnewTables").Is(createnewTables);

            Scan(x =>
                     {
                         x.TheCallingAssembly();
                         x.WithDefaultConventions();
                     });
 
        }
    }
}