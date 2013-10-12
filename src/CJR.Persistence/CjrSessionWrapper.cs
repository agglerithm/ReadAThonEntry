using System;
using System.Data;
using System.Linq.Expressions;
using FluentNHibernate;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Stat;
using NHibernate.Type;


namespace CJR.Persistence
{
    public interface ISessionWrapper : ISession
    {
        void WithinUpdateContext(Action action);
        void BindToCurrentContext();
        void UnbindFromCurrentContext(Exception ex);
    }

    public class CjrSessionWrapper : ISessionWrapper
    {
        private readonly ISession _session;


        public CjrSessionWrapper(ISessionSource source)
        {
            _session = source.CreateSession();
        }

        public void Dispose()
        {
            _session.Dispose();
        }

        public void Flush()
        {
            _session.Flush();
        }

        public IDbConnection Disconnect()
        {
            return _session.Disconnect();
        }

        public void Reconnect()
        {
            _session.Reconnect();
        }

        public void Reconnect(IDbConnection connection)
        {
            _session.Reconnect(connection);
        }

        public IDbConnection Close()
        {
            return _session.Close();
        }

        public void CancelQuery()
        {
            _session.CancelQuery();
        }

        public bool IsDirty()
        {
            return _session.IsDirty();
        }

        public bool IsReadOnly(object entityOrProxy)
        {
            return _session.IsReadOnly(entityOrProxy);
        }

        public void SetReadOnly(object entityOrProxy, bool readOnly)
        {
            _session.SetReadOnly(entityOrProxy, readOnly)
                ;
        }

        public object GetIdentifier(object obj)
        {
            return _session.GetIdentifier(obj);
        }

        public bool Contains(object obj)
        {
            return _session.Contains(obj);
        }

        public void Evict(object obj)
        {
            _session.Evict(obj);
        }

        public object Load(Type theType, object id, LockMode lockMode)
        {
            return _session.Load(theType, id, lockMode);
        }

        public object Load(string entityName, object id, LockMode lockMode)
        {
            return _session.Load(entityName, id, lockMode);
        }

        public object Load(Type theType, object id)
        {
            return _session.Load(theType, id);
        }

        public T Load<T>(object id, LockMode lockMode)
        {
            return _session.Load<T>(id, lockMode);
        }

        public T Load<T>(object id)
        {
            return _session.Load<T>(id);
        }

        public object Load(string entityName, object id)
        {
            return _session.Load(entityName, id);
        }

        public void Load(object obj, object id)
        {
            _session.Load(obj, id);
        }

        public void Replicate(object obj, ReplicationMode replicationMode)
        {
            _session.Replicate(obj, replicationMode);
        }

        public void Replicate(string entityName, object obj, ReplicationMode replicationMode)
        {
            _session.Replicate(entityName,obj,replicationMode);
        }

        public object Save(object obj)
        {
            return _session.Save(obj);
        }

        public void Save(object obj, object id)
        {
            _session.Save(obj, id);
        }

        public object Save(string entityName, object obj)
        {
            return _session.Save(entityName, obj);
        }

        public void SaveOrUpdate(object obj)
        {
            _session.SaveOrUpdate(obj);
        }

        public void SaveOrUpdate(string entityName, object obj)
        {
            throw new NotImplementedException();
        }

        public void Update(object obj)
        {
            throw new NotImplementedException();
        }

        public void Update(object obj, object id)
        {
            throw new NotImplementedException();
        }

        public void Update(string entityName, object obj)
        {
            throw new NotImplementedException();
        }

        public object Merge(object obj)
        {
            throw new NotImplementedException();
        }

        public object Merge(string entityName, object obj)
        {
            throw new NotImplementedException();
        }

        public T Merge<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public T Merge<T>(string entityName, T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Persist(object obj)
        {
            throw new NotImplementedException();
        }

        public void Persist(string entityName, object obj)
        {
            throw new NotImplementedException();
        }

        public object SaveOrUpdateCopy(object obj)
        {
            throw new NotImplementedException();
        }

        public object SaveOrUpdateCopy(object obj, object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(object obj)
        {
            _session.Delete(obj);
        }

        public void Delete(string entityName, object obj)
        {
            throw new NotImplementedException();
        }

        public int Delete(string query)
        {
            throw new NotImplementedException();
        }

        public int Delete(string query, object value, IType type)
        {
            throw new NotImplementedException();
        }

        public int Delete(string query, object[] values, IType[] types)
        {
            throw new NotImplementedException();
        }

        public void Lock(object obj, LockMode lockMode)
        {
            throw new NotImplementedException();
        }

        public void Lock(string entityName, object obj, LockMode lockMode)
        {
            throw new NotImplementedException();
        }

        public void Refresh(object obj)
        {
            throw new NotImplementedException();
        }

        public void Refresh(object obj, LockMode lockMode)
        {
            throw new NotImplementedException();
        }

        public LockMode GetCurrentLockMode(object obj)
        {
            throw new NotImplementedException();
        }

        public ITransaction BeginTransaction()
        {
            return _session.BeginTransaction();
        }

        public ITransaction BeginTransaction(IsolationLevel isolationLevel)
        {
            return _session.BeginTransaction(isolationLevel);
        }

        public ICriteria CreateCriteria<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public ICriteria CreateCriteria<T>(string alias) where T : class
        {
            throw new NotImplementedException();
        }

        public ICriteria CreateCriteria(Type persistentClass)
        {
            throw new NotImplementedException();
        }

        public ICriteria CreateCriteria(Type persistentClass, string alias)
        {
            throw new NotImplementedException();
        }

        public ICriteria CreateCriteria(string entityName)
        {
            throw new NotImplementedException();
        }

        public ICriteria CreateCriteria(string entityName, string alias)
        {
            throw new NotImplementedException();
        }

        public IQueryOver<T, T> QueryOver<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryOver<T, T> QueryOver<T>(Expression<Func<T>> alias) where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryOver<T, T> QueryOver<T>(string entityName) where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryOver<T, T> QueryOver<T>(string entityName, Expression<Func<T>> alias) where T : class
        {
            throw new NotImplementedException();
        }

        public IQuery CreateQuery(string queryString)
        {
            throw new NotImplementedException();
        }

        public IQuery CreateFilter(object collection, string queryString)
        {
            throw new NotImplementedException();
        }

        public IQuery GetNamedQuery(string queryName)
        {
            throw new NotImplementedException();
        }

        public ISQLQuery CreateSQLQuery(string queryString)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            _session.Clear();
        }

        public object Get(Type clazz, object id)
        {
            throw new NotImplementedException();
        }

        public object Get(Type clazz, object id, LockMode lockMode)
        {
            throw new NotImplementedException();
        }

        public object Get(string entityName, object id)
        {
            throw new NotImplementedException();
        }

        public T Get<T>(object id)
        {
            return _session.Get<T>(id);
        }

        public T Get<T>(object id, LockMode lockMode)
        {
            throw new NotImplementedException();
        }

        public string GetEntityName(object obj)
        {
            throw new NotImplementedException();
        }

        public IFilter EnableFilter(string filterName)
        {
            throw new NotImplementedException();
        }

        public IFilter GetEnabledFilter(string filterName)
        {
            throw new NotImplementedException();
        }

        public void DisableFilter(string filterName)
        {
            throw new NotImplementedException();
        }

        public IMultiQuery CreateMultiQuery()
        {
            throw new NotImplementedException();
        }

        public ISession SetBatchSize(int batchSize)
        {
            throw new NotImplementedException();
        }

        public ISessionImplementor GetSessionImplementation()
        {
            return _session.GetSessionImplementation();
        }

        public IMultiCriteria CreateMultiCriteria()
        {
            throw new NotImplementedException();
        }

        public ISession GetSession(EntityMode entityMode)
        {
            throw new NotImplementedException();
        }

        public EntityMode ActiveEntityMode { get; private set; }
        public FlushMode FlushMode { get; set; }
        public CacheMode CacheMode { get; set; }
        public ISessionFactory SessionFactory { get; private set; }
        public IDbConnection Connection { get; private set; }
        public bool IsOpen { get; private set; }
        public bool IsConnected { get; private set; }
        public bool DefaultReadOnly { get; set; }
        public ITransaction Transaction { get; private set; }
        public ISessionStatistics Statistics { get; private set; }
        public void WithinUpdateContext(Action action)
        {
            if (_session.Transaction.IsActive)
            {
                action();
                return;
            }
            using (var trans = _session.BeginTransaction())
            {
                action();
                _session.Flush();
                trans.Commit();
            }
        }

        public void BindToCurrentContext()
        {
            _session.BindToCurrentContext();
        }

        public void UnbindFromCurrentContext(Exception ex)
        {
            _session.UnbindFromCurrentContext(ex);
        }
    }
}