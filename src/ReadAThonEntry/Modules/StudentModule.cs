namespace ReadAThonEntry.Modules
{
    using System;
    using Nancy;
    using Nancy.ModelBinding;
    using DTOs;
    using ViewModels;
    using Repositories; 

    public class StudentModule : NancyModule
    {
        private string _validation;
        public StudentModule(IStudentRepository studentRepo):base("student")
        { 
            Get["/"] = parm => {

                                   //  var url = ConfigurationManager.AppSettings["HostUrl"].ToString();
                                   return View["EditStudent", getStudent()];
            };

            Post["/update"] = parm =>
                                    {
//                                       
                                          var request = this.Bind<StudentDto>();
                                         try
                                         { 
                                             if(validate(request))
                                             {
                                                 studentRepo.Save(request);
                                                 return View["NextStudent",  request];
                                             }
                                             return View["validationerror", _validation];
                                         }
                                         catch(Exception ex)
                                         {
                                             _validation = "An error occurred: " + ex;
                                             return View["validationerror", _validation];
                                         }                                                                          
//                                                                            
                                    };
            Post["/create"] = parm =>
                                     {
                                         var request = this.Bind<StudentDto>();
                                         try
                                         { 
                                             if(validate(request))
                                             {
                                                 studentRepo.Save(request);
                                                 return View["NextStudent",  request];
                                             }
                                             return View["validationerror", _validation];
                                         }
                                         catch(Exception ex)
                                         {
                                             _validation = "An error occurred: " + ex;
                                             return View["validationerror", _validation];
                                         }

                                     };
        }

        private Student getStudent()
        {
            return new Student
                       {
                           EnvelopeNumber = "3234",
                           FirstName = "Bob",
                           LastName = "Cobb",
                           School = "St. Mary's",
                           Teacher = "Mr. Burns",
                           Grade = "First",
                           AmountFromEnvelope = 234,
                           Comments = "I don't know",
                           ShirtSize = ShirtSize.AdultLarge
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