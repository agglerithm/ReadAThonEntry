namespace ReadAThonEntry.ViewModels
{
    using System.Collections.Generic;
    using Microsoft.Practices.ServiceLocation;
    using ReadAThonEntry.DTOs;
    using TimeKeeper.Repositories;

    public class Departments
    {
        public static IEnumerable<SchoolDto> DeptList { get; set; }

        public static IEnumerable<SchoolDto> GetList()
        {
            if(DeptList != null) return DeptList;
            var repo = ServiceLocator.Current.GetInstance<IDepartmentRepository>();
            return DeptList = repo.Query(d => true);
        }
    }
}