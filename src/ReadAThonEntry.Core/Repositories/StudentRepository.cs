using CJR.Common.Extensions;
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
            var student = Query(where).FirstOrDefault();
            if (student == null) return null;
            student.SchoolName =   student.SchoolName;
            student.Prizes =
                _session.Query<PrizeDto>()
                        .Where(p => p.MinAmount <  student.AmountFromEnvelope
                            +  student.AmountFromWebsite).ToList();
            student.TeacherId =   student.TeacherId;
            return student;
        }
 

        public void Save(StudentDto student)
        {
            _session.Flush();
            _session.Save(student);
            _session.Flush();
        }

        public void WithinUpdateContext(Action action)
        {
            _session.WithinUpdateContext(action); 
        }

        public void Delete(StudentDto studentDto)
        {
            _session.Delete(studentDto);
        }
    }
} 