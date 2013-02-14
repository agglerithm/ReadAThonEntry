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
            var lst = Query(where);
            if (lst.Count() > 0)
                return lst.First();
            return null;
        }

        public void Save(StudentDto student)
        {
            base.Save(student);
        }

        public void Update(StudentDto student)
        { 
            base.Update<StudentDto>(student, s => s.FirstName == student.FirstName && s.LastName == student.LastName && s.School == student.School);
        }
    }
} 