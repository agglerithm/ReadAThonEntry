namespace ReadAThonEntry.Core.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using ReadAThonEntry.Core.DTOs;

    public interface ISchoolRepository
    {
        IEnumerable<SchoolDto> Query(Expression<Func<SchoolDto, bool>> where);

        SchoolDto Find(Expression<Func<SchoolDto, bool>> where);

        void Save(SchoolDto school);
    }
}