using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Studywithzk.Data;
using Studywithzk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studywithzk.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExamClassController : BaseController
    {
        private readonly ApplicationDbContext _db;
        public ExamClassController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("/Admin/Class/")]
        public async Task<IActionResult> Index()
        {
            var Li = await _db.ExamClass.ToListAsync();
            return View(Li);
        }
        [HttpGet]
        [Route("/Admin/Class/Create")]
        public IActionResult Create()
        {
            return View(new ExamClass());
        }
        [HttpPost]
        public async Task<IActionResult> Save(ExamClass ExamClass)
        {
            string d;
            if (ExamClass.Id == 0)
            {
                await _db.ExamClass.AddAsync(ExamClass);
                AddNotificationToView("Added Successfully", true);
                d = "Create";
            }
            else
            {
                _db.ExamClass.Update(ExamClass);
                AddNotificationToView("Updated Successfully", true);
                d = "Index";
            }
            await _db.SaveChangesAsync();
            return RedirectToAction(d);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(long Id)
        {
            var Lst = await _db.ExamClass.FindAsync(Id);
            return View("Create", Lst);
        }
    }
}
