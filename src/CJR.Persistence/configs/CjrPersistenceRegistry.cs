
namespace CJR.Persistence.configs
{
    using FluentNHibernate;
    using StructureMap.Configuration.DSL;

    public class CjrPersistenceRegistry<T> : Registry 
    {
        public CjrPersistenceRegistry(bool testMode, bool rebuildSchema, string assembly) 
        { 

            var connectionKey = testMode == false ? "entries.mdb" : "entriesTest.mdb";
            var createnewTables = testMode && rebuildSchema;

            For<ISessionSource>().Singleton().Use<CjrSessionSource<T>>()
              .Ctor<string>("connectionKey").Is(connectionKey)
              .Ctor<string>("assembly").Is(assembly)
              .Ctor<bool>("createnewTables").Is(createnewTables);

            Scan(x =>
                     {
                         x.TheCallingAssembly();
                         x.WithDefaultConventions();
                     });
 
        }
    }
}