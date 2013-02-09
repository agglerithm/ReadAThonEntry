namespace ReadAThonEntry.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Practices.ServiceLocation;
    using Repositories;

    public class Schools
    {
        private IEnumerable<string> _schools;

        public Schools()
        {
            initialize();
        }

        private void initialize()
        {
            _schools =EnrolledList;
        }

        public IEnumerable<string> EnrolledList
        {
            get { return _schools ?? (_schools = GetAll()); }
        }

        private  IEnumerable<string> GetAll()
        {
            var repo = ServiceLocator.Current.GetInstance<ISchoolRepository>();
            return repo.Query(s => s.Name == s.Name).OrderBy(s => s.Name).Select(s => s.Name);
        }
    }
}