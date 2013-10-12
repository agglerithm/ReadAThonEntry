using CJR.Persistence;
using NHibernate.Linq;

namespace ReadAThonEntry.Core.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using DTOs;

    public class StudentRepository :  IStudentRepository 
    {
        private readonly ISessionWrapper _session;

        public StudentRepository(ISessionWrapper wrapper)
        {
            _session = wrapper;
        }

 
        public IEnumerable<StudentDto> Query(Expression<Func<StudentDto, bool>> where)
        {
            return _session.Query<StudentDto>().Where(where);
        }

        public StudentDto Find(Expression<Func<StudentDto, bool>> where)
        {
            return Query(where).FirstOrDefault();
        }

        public void Save(StudentDto student)
        {
            _session.Save(student);
            _session.Flush();
        }

        public void WithinUpdateContext(Action action)
        {
            _session.WithinUpdateContext(action); 
        }
    }
} 