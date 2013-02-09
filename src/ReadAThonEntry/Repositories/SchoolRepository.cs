namespace ReadAThonEntry.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using CJR.Persistence.imports;
    using FluentNHibernate;
    using ReadAThonEntry.DTOs; 

    public class SchoolRepository : Repository, ISchoolRepository 
    {
        public SchoolRepository(ISessionSource source) : base(source)
        {
        }

        public IEnumerable<SchoolDto> Query(Expression<Func<SchoolDto, bool>> where)
        {
            return base.Query<SchoolDto>(where);
        }

        public SchoolDto Find(Expression<Func<SchoolDto, bool>> where)
        {
            return base.FindBy<SchoolDto>(where);
        }

        public void Save(SchoolDto school)
        {
            base.Save(school);
        }
    }


}
