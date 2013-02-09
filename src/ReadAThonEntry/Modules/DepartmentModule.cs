namespace TimeKeeper.Modules
{
    using System;
    using CJR.Common.Extensions;
    using Nancy;
    using Nancy.ModelBinding;
    using ReadAThonEntry.DTOs;
    using Repositories;

    public class DepartmentModule : NancyModule
    {
        private string _validation;
        public DepartmentModule(IDepartmentRepository deptRepo)
            : base("dept")
        {
            Get["/"] = parm =>
            {

                return View["index"];
            };
            Get["/departments"] = parm =>
            {
                return View["Departments"];
            };
            Post["/create"] = parm =>
            {
                var request = this.Bind<SchoolDto>();
                try
                {
                    if (validate(request))
                    {
                        deptRepo.Save(request);
                        return View["Departments"];
                    }
                    return View["validationerror", _validation];
                }
                catch (Exception ex)
                {
                    _validation = "An error occurred: " + ex;
                    return View["validationerror", _validation];
                }

            };
        }

        private bool validate(SchoolDto request)
        {
            if (request == null)
                return setValidation("No request was found!");
            if (request.Name.IsNullOrEmpty())
                return setValidation("You must enter a department name!");
            return true;
        }

        private bool setValidation(string msg)
        {
            _validation = msg;
            return false;
        }
    }
}