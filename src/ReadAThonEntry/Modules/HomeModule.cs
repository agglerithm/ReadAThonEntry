namespace ReadAThonEntry.Modules
{
    using System;
    using System.Linq;
    using Core.Repositories;
    using Nancy;
    using Nancy.ModelBinding;
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
                                      if (request.FirstName == null) request.FirstName = "";
                                      if (request.LastName == null) request.LastName = "";
                                      var students = studentRepo.Query(s => s.School == request.School);
                                              
                                       students = students.Where(s => s.FirstName.StartsLike(request.FirstName) &&
                                                                            s.LastName.StartsLike(request.LastName));

                                      if(students.Count() == 1)
                                          return View["student/EditStudent", students.First().MapToModel()];
                                      if(students.Count() == 0)
                                          return View["student/CreateStudent", request];
                                      return View["StudentLookup", new Students(request, students.Select(s => s.MapToModel()))];
                                  };
            Get["/lookup"] = parm =>
                                 {
                                     var request = this.Bind<StudentSearchCriteria>();
                                     var student =
                                         studentRepo.Find(
                                             s => s.School == request.School && s.FirstName == request.FirstName
                                                  && s.LastName == request.LastName);
                                     if(student == null) throw new Exception("The student you selected was not found in the database!");
                                     return View["student/EditStudent", student.MapToModel()];
                                 }; 
           }
    } 
}