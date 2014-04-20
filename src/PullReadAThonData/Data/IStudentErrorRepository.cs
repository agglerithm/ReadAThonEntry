using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ReadAThonEntry.Core;
using ReadAThonEntry.Core.DTOs;

namespace PullReadAThonData.Data
{
    public interface IStudentErrorRepository
    {
        IEnumerable<StudentErrorDto> Query(Expression<Func<StudentErrorDto, bool>> where);

        StudentErrorDto Find(Expression<Func<StudentErrorDto, bool>> where);

        void Save(StudentErrorDto school);

        void Save(StudentPackage stPkg, Exception ex);
    }
}