using System;
using System.Linq;
using System.Web.Mvc;
using CJR.Common.Extensions;
using ReadAThonEntry.Core.Repositories;
using ReadAThonEntryMvc.Models;
using ReadAThonEntryMvc.Services; 

namespace ReadAThonEntryMvc.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentProcessingService _svc;
        private readonly IStudentRepository _studentRepo;
        private readonly ISchoolRepository _schoolRepo;
        private readonly IStudentMappingHelper _helper;

        public StudentController(IStudentProcessingService svc, 
            IStudentRepository studentRepo, IStudentMappingHelper helper, ISchoolRepository schoolRepo)
        {
            _svc = svc;
            _studentRepo = studentRepo;
            _helper = helper;
            _schoolRepo = schoolRepo;
        }

        public ActionResult create(StudentPrototype request)
        { 
            try
            {
                return _svc.ValidateAndInsert(request, _helper) ? View("NextStudent", new Schools()) : 
                    View("CreateStudent", request);
            }
            catch (Exception ex)
            {
                request.ValidationErrorMsgs = "An error occurred: " + ex;
                return View("CreateStudent", request);
            }
        }

        [HttpGet]
        public ActionResult CreateStudent(string first, string last, long schoolId)
        { 
            StudentPrototype prototype = _helper.CreatePrototype(first, last, schoolId);
            return View(prototype);
        }

        [HttpPost]
        public ActionResult CreateStudent(StudentPrototype student)
        {
            _helper.LoadPrototype(student);
            return create(student);
        }



        [HttpGet]
        public ActionResult EditStudent(string lastname, string firstname, string school)
        {
            var student = _studentRepo.Find(s => s.LastName == lastname
                                                        && s.FirstName == firstname
                                                        && s.SchoolName == school);
            var schoolDto = _schoolRepo.Find(s => s.Name == student.SchoolName);
            return View("EditStudent",  student.MapToModel(schoolDto.Contacts.Find(t => t.Id == student.TeacherId)));
        }

        [HttpPost]
        public ActionResult EditStudent(Student student)
        { 
            try
            {
                return _svc.ValidateAndUpdate(student,_helper) ? View("NextStudent", new Schools()) : View("EditStudent", student);
            }
            catch (Exception ex)
            {
                student.ValidationErrorMsgs = "An error occurred: " + ex;
                return View("EditStudent", student);
            }   
        }

 
    }
}