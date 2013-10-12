using NHibernate.Context;

namespace CJR.Persistence
{
    using FluentNHibernate;

    public class CjrSessionSource<T,TSessionContext>:  SessionSource where TSessionContext : ICurrentSessionContext
    {
        public CjrSessionSource(string connectionKey,  bool createnewTables)
            : base(FluentNHibernateConfigurationBuilder
                .GetFluentNHibernateJetConfiguration<T,TSessionContext>(connectionKey,  createnewTables)) { }
 
    }

    public class CjrSqlSessionSource<T> : SessionSource
    {
        public CjrSqlSessionSource(string connectionKey, bool createNewTables)
            : base(FluentNHibernateConfigurationBuilder
                       .GetFluentNHibernateConfiguration<T>(connectionKey, createNewTables))
        {
            
        }
    }
}