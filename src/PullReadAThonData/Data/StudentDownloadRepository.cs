using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CJR.Persistence;
using NHibernate.Linq;
using ReadAThonEntry.Core;
using ReadAThonEntry.Core.DTOs;
using ReadAThonEntry.Core.Repositories;

namespace PullReadAThonData.Data
{
    public class StudentDownloadRepository : IStudentDownloadRepository
    {
        private readonly ISessionWrapper _session;

        public StudentDownloadRepository(ISessionWrapper session)
        {
            _session = session;
        }


        public IEnumerable<StudentDownloadDto> Query(Expression<Func<StudentDownloadDto, bool>> where)
        {
            return _session.Query<StudentDownloadDto>().Where(where);
        }

        public StudentDownloadDto Find(Expression<Func<StudentDownloadDto, bool>> where)
        {
            return _session.Query<StudentDownloadDto>().FirstOrDefault(where);
        }

        public void Save(StudentDownloadDto student)
        {
            _session.Save(student);
            _session.Flush();
        }

        public void Save(StudentPackage stPkg)
        {
            var student = stPkg.student;
            student.SchoolName = stPkg.school.Name;
            student.TeacherId = stPkg.teacher.Id;

            Save(new StudentDownloadDto(student, stPkg.teacher));
        }
    }
}