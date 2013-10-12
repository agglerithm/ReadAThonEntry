using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CJR.Common.Extensions;
using ReadAThonEntry.Core.Repositories;
using ReadAThonEntryMvc.Models;

namespace ReadAThonEntryMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        //
        // GET: /Home/
        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public ActionResult Index()
        {
            return View( new Schools());
        }

        public ActionResult getlookup(StudentSearchCriteria request)
        { 
            var student =
                _studentRepository.Find(
                    s => s.School == request.School && s.FirstName == request.FirstName
                         && s.LastName == request.LastName);
            if (student == null) throw new Exception("The student you selected was not found in the database!");
            return RedirectToAction("EditStudent", "Student",student.MapToModel());
                              
        }
        [HttpPost]
        public ActionResult lookup(Schools schools, string firstName, string lastName)
        {
            var studentSearch = schools.EnrolledList.Find(s => s.SchoolId == schools.SelectedSchool);
            if (studentSearch.School == "School Not Found")
            {
                studentSearch.SchoolDoesNotExist = true;
                return RedirectToAction("CreateStudent", "Student");
            }
            if (firstName == null) firstName = "";
            if (lastName == null) lastName = "";
            var students = _studentRepository.Query(s => s.School == studentSearch.School);

            students = students.Where(s => s.FirstName.StartsLike(firstName) &&
                                                 s.LastName.StartsLike(lastName)).ToList();

            var cnt = students.Count();
            if (cnt == 1)
                return RedirectToAction("EditStudent", "Student",students.First().MapToModel());
            if (cnt == 0)
                return RedirectToAction("CreateStudent","Student", studentSearch);
            return View("StudentLookup", new Students(studentSearch, students.Select(s => s.MapToModel())));
        }


    }
}
