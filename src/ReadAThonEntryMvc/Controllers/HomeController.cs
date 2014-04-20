using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CJR.Common.Extensions;
using Microsoft.Practices.ServiceLocation;
using ReadAThonEntry.Core.Repositories;
using ReadAThonEntryMvc.Models;

namespace ReadAThonEntryMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ISchoolRepository _schoolRepository;
        //
        // GET: /Home/
        public HomeController(IStudentRepository studentRepository, ISchoolRepository schoolRepository)
        {
            _studentRepository = studentRepository;
            _schoolRepository = schoolRepository;
        }

        public HomeController()
        {
            _schoolRepository = ServiceLocator.Current.GetInstance<ISchoolRepository>();
            _studentRepository = ServiceLocator.Current.GetInstance<IStudentRepository>();
        }

        public ActionResult Index()
        {
            return View( new Schools());
        }

        public ActionResult getlookup(StudentSearchCriteria request)
        { 
            var student =
                _studentRepository.Find(
                    s => s.SchoolName == request.School.Name && s.FirstName == request.FirstName
                         && s.LastName == request.LastName);
            var teacher = _schoolRepository.Find(s => s.Id == request.SchoolId).Contacts.Find(t => t.Id == student.TeacherId);

            if (student == null) throw new Exception("The student you selected was not found in the database!");
            return RedirectToAction("EditStudent", "Student",student.MapToModel(teacher));
                              
        }
        [HttpPost]
        public ActionResult lookup(Schools schools, string firstName, string lastName)
        {
            var studentSearch =     schools.EnrolledList.Find(s => s.SchoolId == schools.SelectedSchoolId);
            if (studentSearch.School.Name ==  "School Not Found")
            {
                studentSearch.SchoolDoesNotExist = true;
                return RedirectToAction("CreateStudent", "Student");
            }
            if (firstName == null) firstName = "";
            if (lastName == null) lastName = "";
            var students = _studentRepository.Query(s => s.SchoolName == studentSearch.SchoolName);

            students = students.Where(s => s.FirstName.StartsLike(firstName) &&
                                                 s.LastName.StartsLike(lastName)).ToList();

            var cnt = students.Count();
            if (cnt == 1)
            {
                var student = students.First();
                return RedirectToAction("EditStudent", "Student", new { lastname = student.LastName, firstname = student.FirstName, school = studentSearch.School.Name });
            } 
            if (cnt == 0)
            { 
                return RedirectToAction("CreateStudent","Student", 
                    new {last = lastName, first = firstName, schoolId = studentSearch.School.Id});
            } 
            return View("StudentLookup", 
                new Students(studentSearch, students.Select(s => s.MapToModel(null))));
        }


    }
}
