using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Context;

namespace CJR.Persistence
{
    public static class Extensions
    {
        public static void BindToCurrentContext(this ISession session)
        {
            CurrentSessionContext.Bind(session);
            session.BeginTransaction();
        }

        public static void UnbindFromCurrentContext(this ISession session, Exception ex)
        {
            var transaction = session.Transaction;
            if (transaction == null || !transaction.IsActive) return;
            if (ex != null)
            {
                transaction.Rollback();
            }
            else
            {
                transaction.Commit();
            }

            session.Close();
            session.Dispose();

        }
    }
}
