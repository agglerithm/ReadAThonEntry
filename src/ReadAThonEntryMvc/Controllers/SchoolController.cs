using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CJR.Common.Extensions;
using ReadAThonEntry.Core.DTOs;
using ReadAThonEntry.Core.Repositories;
using ReadAThonEntryMvc.Models;

namespace ReadAThonEntryMvc.Controllers
{
    public class SchoolController : Controller
    {
        //
        // GET: /Default1/
        private readonly ISchoolRepository _schoolRepo;

        public SchoolController(ISchoolRepository schoolRepo)
        {
            _schoolRepo = schoolRepo;
        }

        public ActionResult Index()
        {
            return View(_schoolRepo.GetAll().Select(s => new School(){Id = (int) s.Id,
            Name = s.Name}));
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(School school)
        {
            var dto = new SchoolDto()
                {
                    Name = school.Name
                };
            _schoolRepo.Save(dto);
            return RedirectToAction("Index");
        }
 

        public ActionResult Delete(long id)
        {
            _schoolRepo.Delete(id);
            return RedirectToAction("Index");
        }


        public ActionResult Edit(long Id)
        {
            var school = _schoolRepo.Find(s => s.Id == Id);
            return View(school.MapToModel(false));
        }

        [HttpPost]
        public ActionResult Edit(School school)
        {
            var dto = _schoolRepo.Find(s => s.Id == school.Id);
            dto.Name = school.Name;
            dto.Address1 = school.Address1;
            dto.City = school.City;
            dto.State = school.State;
            dto.NumberOfClassrooms = school.NumberOfClassrooms;
            dto.Zip = school.Zip;
            return RedirectToAction("Index");
        }
    }
}
