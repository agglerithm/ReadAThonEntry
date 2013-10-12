using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using FluentNHibernate;
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
            var sess = DependencyResolver.Current.GetService<ISessionSource>();
            var repo =  DependencyResolver.Current.GetService<ISchoolRepository>();
            return repo.Query(s => s.Name == s.Name)
                .OrderBy(s => s.Name)
                .Select(s => new StudentSearchCriteria(){School = s.Name, SchoolId = s.Id});
        }

        public int SelectedSchool { get; set; }
    }
}