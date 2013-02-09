namespace ReadAThonEntry.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using DTOs;

    public interface ISchoolRepository
    {
        IEnumerable<SchoolDto> Query(Expression<Func<SchoolDto, bool>> where);

        SchoolDto Find(Expression<Func<SchoolDto, bool>> where);

        void Save(SchoolDto school);
    }
}