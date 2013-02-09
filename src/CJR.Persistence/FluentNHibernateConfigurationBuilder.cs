namespace CJR.Persistence
{
    using System.Reflection;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using NHibernate.Tool.hbm2ddl;

    public static class FluentNHibernateConfigurationBuilder  
    {

        public static FluentConfiguration GetFluentNHibernateConfiguration(string connectionKey, string assembly, bool createNewTables)
        { 
                return Fluently.Configure()
                     .Database(MsSqlConfiguration
                     .MsSql2005.ConnectionString(c => c.FromAppSetting(connectionKey)))
                     .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.Load(assembly)))
                     .ProxyFactoryFactory("NHibernate.ByteCode.LinFu.ProxyFactoryFactory, NHibernate.ByteCode.Linfu")
                                    .ExposeConfiguration(cfg => { 
                     if (createNewTables == false) return;
                                                                      new SchemaExport(cfg).Create(true, true); 
                                                             })
                                               ; 

 

        }

        public static FluentConfiguration GetFluentNHibernateJetConfiguration<T>(string dbPath,  bool createNewTables)
        { 
            return Fluently.Configure()
                .Database(JetDriverConfiguration
                .Standard.ConnectionString(dbPath))
                     .Mappings(m => m.FluentMappings.AddFromAssemblyOf<T>())
                .ProxyFactoryFactory("NHibernate.ByteCode.LinFu.ProxyFactoryFactory, NHibernate.ByteCode.Linfu")
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