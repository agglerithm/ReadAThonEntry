namespace ReadAThonEntry.Modules
{
    using System;
    using Nancy;
    using Nancy.ModelBinding;
    using Services;
    using ViewModels;

    public class StudentModule : NancyModule
    {
        public StudentModule(IStudentProcessingService svc):base("student")
        { 
 

            Post["/update"] = parm =>
                                    {
//                                       
                                          var requestPrototype = this.Bind<StudentPrototype>();
                                         try
                                         {
                                             return svc.ValidateAndUpdate(requestPrototype) ? View["NextStudent", new Schools()] : View["EditStudentRetry", requestPrototype];
                                         }
                                         catch(Exception ex)
                                         {
                                             requestPrototype.ValidationErrorMsgs  = "An error occurred: " + ex;
                                             return View["EditStudentRetry", requestPrototype];
                                         }                                                                          
//                                                                            
                                    };
            Post["/create"] = parm =>
                                     {
                                         var request = this.Bind<StudentPrototype>();
                                         try
                                         {
                                             return svc.ValidateAndInsert(request) ? View["NextStudent", new Schools()] : View["CreateStudentRetry", request];
                                         }
                                         catch(Exception ex)
                                         {
                                             request.ValidationErrorMsgs = "An error occurred: " + ex;
                                             return View["CreateStudentRetry", request];
                                         }

                                     };
        }
 
    }
}