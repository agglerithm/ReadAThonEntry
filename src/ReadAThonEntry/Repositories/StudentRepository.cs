namespace ReadAThonEntry.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using CJR.Persistence.imports;
    using DTOs;
    using FluentNHibernate;
    using NHibernate;

    public class StudentRepository : Repository, IStudentRepository 
    {
        public StudentRepository(ISessionSource source) : base(source)
        {
        }

        protected StudentRepository(ISession session) : base(session)
        {
        }

        public IEnumerable<StudentDto> Query(Expression<Func<StudentDto, bool>> where)
        {
            return base.Query(where);
        }

        public StudentDto Find(Expression<Func<StudentDto, bool>> where)
        {
            return base.FindBy(where);
        }

        public void Save(StudentDto student)
        {
            base.Save(student);
        }
    }
}