using System;
using System.Web.Mvc;
using ReadAThonEntry.Core.Repositories;
using ReadAThonEntryMvc.Models;
using IStudentProcessingService = ReadAThonEntryMvc.Services.IStudentProcessingService;

namespace ReadAThonEntryMvc.Controllers
{
    public class StudentController : Controller
    {
        private IStudentProcessingService _svc;
        private IStudentRepository _studentRepo;
        public StudentController(IStudentProcessingService svc, IStudentRepository studentRepo)
        {
            _svc = svc;
            _studentRepo = studentRepo;
        }

        public ActionResult create(StudentPrototype request)
        { 
            try
            {
                return _svc.ValidateAndInsert(request) ? View("NextStudent", new Schools()) : View("CreateStudentRetry", request);
            }
            catch (Exception ex)
            {
                request.ValidationErrorMsgs = "An error occurred: " + ex;
                return View("CreateStudentRetry", request);
            }
        }

        [HttpGet]
        public ActionResult CreateStudent(string FirstName, string LastName, string School)
        {
            return View(new StudentSearchCriteria() {FirstName = FirstName, LastName = LastName, School = School});
        }

        [HttpPost]
        public ActionResult CreateStudent(StudentPrototype student)
        {
            return create(student);
        }

 
        [HttpGet]
        public ActionResult EditStudent(string lastname, string firstname, string school)
        {
            var student = _studentRepo.Find(s => s.LastName == lastname
                                                        && s.FirstName == firstname
                                                        && s.School == school);
            return View("EditStudent",  student.MapToModel());
        }

        [HttpPost]
        public ActionResult EditStudent(StudentPrototype requestPrototype)
        {
            try
            {
                return _svc.ValidateAndUpdate(requestPrototype) ? View("NextStudent", new Schools()) : View("EditStudentRetry", requestPrototype);
            }
            catch (Exception ex)
            {
                requestPrototype.ValidationErrorMsgs = "An error occurred: " + ex;
                return View("EditStudentRetry", requestPrototype);
            }   
        }

 
    }
}