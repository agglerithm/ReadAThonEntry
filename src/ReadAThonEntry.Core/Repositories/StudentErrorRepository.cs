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

    public class StudentErrorRepository : Repository, IStudentErrorRepository 
    {
        public StudentErrorRepository(ISessionSource source) : base(source)
        {
        }

        protected StudentErrorRepository(ISession session) : base(session)
        {
        }

        public IEnumerable<StudentErrorDto> Query(Expression<Func<StudentErrorDto, bool>> where)
        {
            return base.Query(where);
        }

        public StudentErrorDto Find(Expression<Func<StudentErrorDto, bool>> where)
        {
            var lst = Query(where);
            return lst.Count() > 0 ? lst.First() : null;
        }

        public void Save(StudentErrorDto student)
        {
            base.Save(student);
        }
    }
}