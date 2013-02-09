namespace CJR.Persistence
{
    using System;
    using FluentNHibernate;
    using NHibernate;

    public class NHibernateUnitOfWork : INHibernateUnitOfWork
    {
        // Fields
        private bool _isDisposed;
        private bool _isInitialized;
        private readonly ISessionSource _source;
        private ITransaction _transaction;


        // Methods
        public NHibernateUnitOfWork(ISessionSource source)
        {
            this._source = source;
        }


        private void begin_new_transaction()
        {
            if (this._transaction != null)
            {
                this._transaction.Dispose();
            }
            this._transaction = this.CurrentSession.BeginTransaction();
        }

        public void Commit()
        {
            this.should_not_currently_be_disposed();
            this.should_be_initialized_first();
            this._transaction.Commit(); 
        }

        public void Dispose()
        {
            if (!this._isDisposed && this._isInitialized)
            {
                this._transaction.Dispose();
                this.CurrentSession.Dispose();
                this._isDisposed = true;
            }
        }

        public void Rollback()
        {
            this.should_not_currently_be_disposed();
            this.should_be_initialized_first();
            this._transaction.Rollback(); 
        }

        private void should_be_initialized_first()
        {
            if (!this._isInitialized)
            {
                throw new InvalidOperationException("Must initialize (call Start()) on NHibernateUnitOfWork before commiting or rolling back");
            }
        }

        private void should_not_currently_be_disposed()
        {
            if (this._isDisposed)
            {
                throw new ObjectDisposedException(base.GetType().Name);
            }
        }

        public void Start()
        {
            this.should_not_currently_be_disposed();
            this.CurrentSession = this._source.CreateSession();
            this.begin_new_transaction();
            this._isInitialized = true;
        }

        public static INHibernateUnitOfWork Start(ISessionSource source)
        {
            NHibernateUnitOfWork work = new NHibernateUnitOfWork(source);
            work.Start();
            return work;
        }

        // Properties
        public ISession CurrentSession
        {
            get;
            set;
        }
    }
}