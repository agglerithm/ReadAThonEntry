using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CJR.Common.Extensions;
using CJR.Persistence;
using NHibernate.Linq;
using ReadAThonEntry.Core.DTOs;

namespace ReadAThonEntry.Core.Repositories
{
    public class PrizeRepository : IPrizeRepository
    {
        private readonly ISessionWrapper _session;

        public PrizeRepository(ISessionWrapper session)
        {
            _session = session;
        } 

        public IEnumerable<PrizeDto> Query(Expression<Func<PrizeDto, bool>> @where)
        {
            return _session.Query<PrizeDto>().Where(where);
        }

        public PrizeDto Find(Predicate<PrizeDto> @where)
        {
            return GetAll().Find<PrizeDto>(@where);
        }

        public IEnumerable<PrizeDto> GetAll()
        {
            return _session.Query<PrizeDto>();
        }

        public void Save(PrizeDto student)
        {
            _session.Save(student);
        }

        public void WithinUpdateContext(Action action)
        {
            var trans = _session.BeginTransaction();
            action();
            trans.Commit();
        }
    }
}