using System.Linq; 
using CJR.Common.Extensions;
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

        public SchoolDto Find(Predicate< SchoolDto> where)
        {
            return GetAll().Find(where);
        }

        public void Save(SchoolDto school)
        {
            _session.Save(school);
        }

        public void Delete(long id)
        {
            _session.Delete(Find(s => s.Id == id));
        }

        public void Expel(SchoolDto school)
        {
            _session.Evict(school);
        }

        public void AddContact(SchoolDto school, ContactDto contactDto)
        {
            contactDto.Id =  (long) _session.Save(contactDto);
            school.Contacts.Add(contactDto);
            _session.Flush();
        }
    } 
}
