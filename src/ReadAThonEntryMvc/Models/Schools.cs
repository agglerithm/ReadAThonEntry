using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CJR.Persistence;
using FluentNHibernate;
using NHibernate.Linq;
using ReadAThonEntry.Core.DTOs;
using ReadAThonEntry.Core.Repositories;

namespace ReadAThonEntryMvc.Models
{
    public class Schools
    {
        private IEnumerable<StudentSearchCriteria> _schools;

        public Schools()
        {
            initialize();
        }

        private void initialize()
        {
            _schools =EnrolledList;
        }

        public IEnumerable<StudentSearchCriteria> EnrolledList
        {
            get { return _schools ?? (_schools = GetAll()); }
        }

        private  IEnumerable<StudentSearchCriteria> GetAll()
        {
            var sess = DependencyResolver.Current.GetService<ISessionWrapper>(); 
            return sess.Query<SchoolDto>()
                .OrderBy(s => s.Name)
                .Select(s => new StudentSearchCriteria(){School = s.MapToModel(true)});
        }

        public long SelectedSchoolId { get; set; }
    }
}