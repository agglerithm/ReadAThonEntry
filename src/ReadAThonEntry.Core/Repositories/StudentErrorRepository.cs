using CJR.Persistence;
using NHibernate.Linq;

namespace ReadAThonEntry.Core.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using CJR.Persistence.imports;
    using DTOs;
    using FluentNHibernate;
    using NHibernate;

    public class StudentErrorRepository :  IStudentErrorRepository 
    {
        private readonly ISessionWrapper _session;

        public StudentErrorRepository(ISessionWrapper session)
        {
            _session = session;
        }


        public IEnumerable<StudentErrorDto> Query(Expression<Func<StudentErrorDto, bool>> where)
        {
            return _session.Query<StudentErrorDto>().Where(where);
        }

        public StudentErrorDto Find(Expression<Func<StudentErrorDto, bool>> where)
        {
            return _session.Query<StudentErrorDto>().FirstOrDefault(where); 
        }

        public void Save(StudentErrorDto student)
        {
            _session.Save(student);
        }
    }
}