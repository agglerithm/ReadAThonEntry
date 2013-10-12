namespace ReadAThonEntry.Core.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using ReadAThonEntry.Core.DTOs;

    public interface IStudentRepository
    {
        IEnumerable<StudentDto> Query(Expression<Func<StudentDto, bool>> where);

        StudentDto Find(Expression<Func<StudentDto, bool>> where);

        void Save(StudentDto student);
         
        void WithinUpdateContext(Action action);
    }
}