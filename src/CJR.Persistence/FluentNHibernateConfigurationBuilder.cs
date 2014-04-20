using NHibernate.Context;

namespace CJR.Persistence
{
    using System.Reflection;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using NHibernate.Tool.hbm2ddl;

    public static class FluentNHibernateConfigurationBuilder  
    {

        public static FluentConfiguration GetFluentNHibernateConfiguration<T,TSessionContext>(string connectionKey,  bool createNewTables) where TSessionContext : ICurrentSessionContext
        { 
                return Fluently.Configure()
                     .Database(MsSqlConfiguration
                     .MsSql2008.ConnectionString(c => c.FromConnectionStringWithKey(connectionKey)))
                     .Mappings(m => m.FluentMappings.AddFromAssemblyOf<T>())
                     .CurrentSessionContext<TSessionContext>()
                                    .ExposeConfiguration(cfg => { 
                     if (createNewTables == false) return;
                                                                      new SchemaExport(cfg).Create(true, true); 
                                                             })
                                               ; 

 

        }

        public static FluentConfiguration GetFluentNHibernateJetConfiguration<T,TSessionContext>(string dbPath,  bool createNewTables) where TSessionContext : ICurrentSessionContext
        { 
            return Fluently.Configure()
                .Database(JetDriverConfiguration
                .Standard.ConnectionString(dbPath))
                     .Mappings(m => m.FluentMappings.AddFromAssemblyOf<T>())
                     .CurrentSessionContext<TSessionContext>()
                .Diagnostics(x => x.Enable(true))
                                    .ExposeConfiguration(cfg =>
                                    {
                                        if (createNewTables == false) return;
                                        new SchemaExport(cfg).Create(true, true);
                                    })
                                               ; 
        }
    }
}