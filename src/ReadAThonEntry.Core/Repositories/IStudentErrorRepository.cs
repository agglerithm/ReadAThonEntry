namespace ReadAThonEntry.Core.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using DTOs;

    public interface IStudentErrorRepository
    {
        IEnumerable<StudentErrorDto> Query(Expression<Func<StudentErrorDto, bool>> where);

        StudentErrorDto Find(Expression<Func<StudentErrorDto, bool>> where);

        void Save(StudentErrorDto school);

    }
}