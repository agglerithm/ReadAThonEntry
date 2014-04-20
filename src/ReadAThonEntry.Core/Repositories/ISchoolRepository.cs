namespace ReadAThonEntry.Core.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using ReadAThonEntry.Core.DTOs;

    public interface ISchoolRepository
    {
        IEnumerable<SchoolDto> GetAll();
        
        IEnumerable<SchoolDto> Query(Expression<Func<SchoolDto, bool>> where);

        SchoolDto Find(Predicate< SchoolDto> where);

        void Save(SchoolDto school);
        void Delete(long id);
        void Expel(SchoolDto school);
        void AddContact(SchoolDto school, ContactDto contactDto);
    }
}