using System.Linq;
using CJR.Persistence;
using NHibernate.Linq;

namespace ReadAThonEntry.Core.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using ReadAThonEntry.Core.DTOs;

    public class SchoolRepository :  ISchoolRepository 
    {
        private readonly ISessionWrapper _session;

        public SchoolRepository(ISessionWrapper session)
        {
            _session = session;
        }

        public IEnumerable<SchoolDto> GetAll()
        {
            return _session.Query<SchoolDto>();
        }

        public IEnumerable<SchoolDto> Query(Expression<Func<SchoolDto, bool>> where)
        {
            return _session.Query<SchoolDto>().Where(where);
        }

        public SchoolDto Find(Expression<Func<SchoolDto, bool>> where)
        {
            return _session.Query<SchoolDto>().FirstOrDefault<SchoolDto>(where);
        }

        public void Save(SchoolDto school)
        {
            _session.Save(school);
        }
    }


}
