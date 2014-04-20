using CJR.Persistence;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ReadAThonEntry.Core;

namespace PullReadAThonData.Data
{
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

        public void Save(StudentPackage stPkg, Exception ex)
        {
            var student = stPkg.student;
            student.SchoolName = stPkg.school.Name; 

            Save(new StudentErrorDto(student, stPkg.teacher, ex));
        }
    }

    public interface IStudentDownloadRepository
    {
        void Save(StudentPackage stPkg);
    }
}