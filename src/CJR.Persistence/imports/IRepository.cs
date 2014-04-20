using CJR.Common;
using CJR.Common.Extensions;

namespace CJR.Persistence.imports
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions; 
    using FluentNHibernate;
    using FluentNHibernate.Data;
    using NHibernate.Criterion;
    using NHibernate.Linq;
    using NHibernate.Type;
    using Expression = NHibernate.Criterion.Expression;

    public interface IRepository
    {
        T Find<T>(long id) where T : Entity;
        T[] Query<T>(Expression<Func<T, bool>> where);
        T FindBy<T, U>(Expression<Func<T, U>> expression, U search) where T : class;
        T FindBy<T>(Expression<Func<T, bool>> where) where T : class;
        bool Save<T>(T target) where T : Entity; 
        void Execute(string sql);
        T[] GetAll<T>();
        void DeleteAll<T>();
        INHibernateUnitOfWork StartIQueryable(); 
    }

    public class Repository : IRepository
    {
        private readonly ISessionSource _source;
        private readonly IUniqueKeyExpressionBuilder _exprBuilder;

 
        public Repository(ISessionSource source, IUniqueKeyExpressionBuilder exprBuilder)
        {
            _source = source;
            _exprBuilder = exprBuilder;
        }

        #region IRepository Members



        public T Find<T>(long id) where T : Entity
        {
            using (var uow =  NHibernateUnitOfWork.Start(_source))
            {
                return uow.CurrentSession.Get<T>(id);
            }
        }

        private static void Delete<T>(T target, INHibernateUnitOfWork uow)
        {
            uow.CurrentSession.Delete(target);
        }

        public T[] Query<T>(Expression<Func<T, bool>> where)
        {
            using (var uow =  NHibernateUnitOfWork.Start(_source))
            {
                return uow.CurrentSession.Query<T>().Where(where).ToArray();
            }
        }


        public void Execute(string sql)
        {
            using (var uow =  NHibernateUnitOfWork.Start(_source))
            {
                var qry = uow.CurrentSession.CreateSQLQuery(sql);
                qry.ExecuteUpdate();
            }
        }

        public T[] GetAll<T>()
        {
            using (var uow =  NHibernateUnitOfWork.Start(_source))
            {
                return uow.CurrentSession.Query<T>().ToArray();
            }
        }

        #endregion

        public bool Save<T>(T target) where T : Entity
        {
            var ent = (Entity)target;
            var logMsg = ent.GetLogMessage();
            Logger.Debug(this, "Saving: " + logMsg);
            if (target.Id == 0)
            {
                var id = GetId(_exprBuilder.BuildExpressionFor(target));
                //Id must not be assigned if record doesn't exist
                if (id > 0) target.Id = id;
            }
            using (var uow =  NHibernateUnitOfWork.Start(_source))
            {
                uow.CurrentSession.Flush();
                try
                { 
                    uow.CurrentSession.SaveOrUpdate(target); 
                    uow.Commit();

                }
                catch (NHibernate.TransactionException trxEx)
                {
                    Logger.Error(this, string.Format("Transaction failed saving: {0}", logMsg), trxEx);
                }
                catch (NHibernate.Exceptions.GenericADOException adoEx)
                {
                    Logger.Error(this, string.Format("ADO failure saving: {0}", logMsg), adoEx);
                    if (!adoEx.ToString().Contains("Timeout expired.  The timeout period elapsed prior to completion of the operation"))
                    {
                        Logger.Info(this, "Continuing after non-timeout error...");
                        return false;
                    }
                    throw;
                }
            }
            return true;
        }


        private long GetId<T>(Expression<Func<T, bool>> where) where T : Entity
        {
            if (where == null) return 0;
            var dto = FindBy(where);
            return dto == null ? 0 : dto.Id;
        }

        public T FindBy<T, U>(Expression<System.Func<T, U>> expression, U search) where T : class
        {
            string propertyName = ReflectionHelper.GetProperty(expression).Name;

            using (var uow = NHibernateUnitOfWork.Start(_source))
            {
                var criteria = uow.CurrentSession.CreateCriteria(typeof(T)).Add(Restrictions.Eq(propertyName, search));
                return criteria.UniqueResult() as T;
            }
        }

        public T FindBy<T>(Expression<System.Func<T, bool>> where) where T : class
        {
            using (var uow = NHibernateUnitOfWork.Start(_source))
            {
                var lst = Query(where).EagerLoad();
                if (lst.Count() == 0) return null;
                return lst.First();
            }
        }

        public void DeleteWhere<T>(Expression<System.Func<T, bool>> where)
        {
            var lst = Query(where);
            delete_list(lst.ToList());
        }


        public void DeleteAll<T>()
        {
            var lst = GetAll<T>().ToList();
            delete_list(lst);
        }

        public INHibernateUnitOfWork StartIQueryable()
        {
            return  NHibernateUnitOfWork.Start(_source);
        }

        protected R GetMax<T, R>(string name, string prop, string val)
        {
            using (var uow =  NHibernateUnitOfWork.Start(_source))
            {
                IProjection p = Projections.Max(name);
                var sess = uow.CurrentSession;
                return (R) sess.CreateCriteria(typeof (T))
                    .Add(Expression.Eq(prop, val))
                    .SetProjection(p)  
                    .UniqueResult();
            }
        }

        protected R GetMax<T, R>(string name, string prop, string val, IType type)
        { 
            using (var uow =  NHibernateUnitOfWork.Start(_source))
            {
                IProjection p = Projections.Max(Projections.Cast(type,Projections.Property(name)));
                var sess = uow.CurrentSession;
                return (R)sess.CreateCriteria(typeof(T))
                    .Add(Expression.Eq(prop, val))
                    .SetProjection(p)
                    .UniqueResult();
            }
        }

        private void delete_list<T>(List<T> lst)
        {
            using (var uow =  NHibernateUnitOfWork.Start(_source))
            {
                try
                {
                    lst.ForEach(obj => Delete(obj, uow));
                }
                catch (Exception)
                {
                    uow.Rollback();
                    throw;
                }

                uow.Commit();
            }
        }


    }
}
