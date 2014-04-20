using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CJR.Common.Extensions;
using CJR.Persistence.imports;
using ReadAThonEntry.Core.DTOs;
using ReadAThonEntry.Core.Repositories;
using ReadAThonEntryMvc.Models;

namespace ReadAThonEntryMvc.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        private readonly ISchoolRepository _schoolRepo; 

        public ContactController(ISchoolRepository schoolRepo )
        {
            _schoolRepo = schoolRepo; 
        }

        public ActionResult Index(int Id)
        {
            var school = _schoolRepo.Find(s => s.Id == Id);
            return View(school.MapToModel(false));
        }

        public ActionResult Add(int Id)
        {
            var school = _schoolRepo.Find(s => s.Id == Id);
            return View(school.MapToModel(false));
        }

        [HttpPost]
        public ActionResult Add(int Id,
                                string FirstName, string LastName, string Title)
        { 
            var school = _schoolRepo.Find(s => s.Id == Id); 
            _schoolRepo.AddContact(school, new ContactDto
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    Title = Title
                });
            return View("Index", school.MapToModel(false));
        }

        public ActionResult Edit(long contactId, string schoolName)
        {
            var school = _schoolRepo.Find(s => s.Name ==schoolName);
            var dto = school.Contacts.Find(c => c.Id ==contactId);  
            return View(dto.MapToModel(school));
        }

        [HttpPost]
        public ActionResult Edit(Contact contact)
        {  
            var school = _schoolRepo.Find(s => s.Name == contact.School);
            var dto = school.Contacts.Find(c => c.Id == contact.Id);
            dto.FirstName = contact.FirstName;
            dto.LastName = contact.LastName;
            dto.Title = contact.Title;
            return RedirectToAction("Index", new { Id = school.Id});
        }

        public ActionResult BackToSchool(long id)
        {
            return RedirectToAction("Edit", "School", new {Id = id});
        }
    }
}
