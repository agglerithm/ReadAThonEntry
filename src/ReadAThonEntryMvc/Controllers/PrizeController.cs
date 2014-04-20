using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReadAThonEntry.Core.DTOs;
using ReadAThonEntry.Core.Repositories;
using ReadAThonEntryMvc.Models;

namespace ReadAThonEntryMvc.Controllers
{
    public class PrizeController : Controller
    {
        //
        // GET: /Prize/
        private readonly IPrizeRepository _prizeRepo;

        public PrizeController(IPrizeRepository prizeRepo)
        {
            _prizeRepo = prizeRepo;
        }

        public ActionResult Index()
        {
            var lst = _prizeRepo.GetAll();
            return View(lst.Select(p => new Prize()
            {
                Description = p.Description,
                MaxAmount = p.MaxAmount, 
                MinAmount = p.MinAmount ,
                Id = p.Id
            }));
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Prize prize)
        {
            var dto = new PrizeDto()
                {
                    Description = prize.Description,
                    MaxAmount = prize.MaxAmount,
                    MinAmount = prize.MinAmount
                };
            _prizeRepo.Save(dto);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            var prize = _prizeRepo.Find(p => p.Id == Id);
            return View(new Prize()
            {
                Description = prize.Description, 
                Id = Id, 
                MaxAmount = prize.MaxAmount,
                MinAmount = prize.MinAmount
            });
        }

        [HttpPost]
        public ActionResult Edit(Prize prize)
        {
            var prizeDto = _prizeRepo.Find(p => p.Id == prize.Id);
            prizeDto.Description = prize.Description;
            prizeDto.MaxAmount = prize.MaxAmount;
            prizeDto.MinAmount = prize.MinAmount;
            return RedirectToAction("Index");
        }
    }
}
