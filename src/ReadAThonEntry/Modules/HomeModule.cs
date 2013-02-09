namespace ReadAThonEntry.Modules
{
    using System;
    using Nancy;
    using Nancy.ModelBinding;
    using DTOs;
    using Repositories;
    using ViewModels; 

    public class HomeModule : NancyModule
    { 
        private string _validation;
        public HomeModule(IStudentRepository studentRepo)
        {
            Get["/"] = parm =>
                           {

                               //  var url = ConfigurationManager.AppSettings["HostUrl"].ToString();
                               return View["Index", new Schools()];
                           }; 

        Post["/lookup"] = parm =>
                                  {
                                      var request = this.Bind<StudentSearchCriteria>();
                                      if (request.School == "School Not Found")
                                      {
                                          request.SchoolDoesNotExist = true;
                                          return View["student/CreateStudent", request];
                                      }
                                      var student =
                                          studentRepo.Find(
                                              s =>
                                              s.School.Name == request.School && s.FirstName == request.FirstName &&
                                              s.LastName == request.LastName);
                                      if(student != null)
                                        return View["student/EditStudent", student];
                                      return View["student/CreateStudent", request];
                                  }; 
    }

        private Student getStudent()
        {
            return new Student
                       {
                           FirstName = "Bob",
                           LastName = "Cobb",
                           School = "St. Mary's",
                           Teacher = "Mr. Burns",
                           Grade = "First"
                       };
        }

        private bool validate(StudentDto request)
        {
//            var hours = request.Hours();
//            if (hours >= 0)
//            {
//                if (hours == 0)
//                    return setValidation("Zero hours were entered."); 
//            }
//            else
//            {
//                _validation = "Start time must be less than end time!";
//                return false;
//            }
//            if (request.Department.IsNullOrEmpty())
//                return setValidation("Must include a department!");
            return true;
        }

        private bool setValidation(string msg)
        {
            _validation = msg;
            return false;
        }
    }
}