namespace ReadAThonEntry.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using ReadAThonEntry.DTOs;

    public interface IStudentRepository
    {
        IEnumerable<StudentDto> Query(Expression<Func<StudentDto, bool>> where);

        StudentDto Find(Expression<Func<StudentDto, bool>> where);

        void Save(StudentDto school);
        
    }
}