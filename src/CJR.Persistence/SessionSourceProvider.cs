namespace CJR.Persistence
{
    using FluentNHibernate;

    public class CjrSessionSource<T>:  SessionSource 
    {
        public CjrSessionSource(string connectionKey,  bool createnewTables)
            : base(FluentNHibernateConfigurationBuilder
                .GetFluentNHibernateJetConfiguration<T>(connectionKey,  createnewTables)) { }
 
    }
}