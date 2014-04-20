using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CJR.Common.Extensions;
using CJR.Persistence;
using Microsoft.Practices.ServiceLocation;
using NHibernate.Linq;
using ReadAThonEntry.Core.DTOs;

namespace ReadAThonEntry.Core.Repositories
{
    public class TitleRepository : ITitleRepository
    {
        private readonly ISessionWrapper _session;

        public TitleRepository(ISessionWrapper session)
        {
            _session = session;
        }
 

        public TitleDto Insert(string name)
        {
            return (TitleDto) _session.Save(new TitleDto {TitleName = name});
        }

        public IEnumerable<TitleDto> GetAll()
        {
            return _session.Query<TitleDto>();
        }

        public TitleDto Find(string name)
        {
            return _session.Query<TitleDto>().Find(t => t.TitleName == name);
        }
    }
}