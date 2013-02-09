namespace CJR.Persistence
{
    using System;
    using NHibernate;

    public interface INHibernateUnitOfWork : IDisposable
    {
        ISession CurrentSession { get; }
        void Commit();
        void Rollback();
    }
}