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
    public class ExamSubjectController : BaseController
    {
        private readonly ApplicationDbContext _db;
        public ExamSubjectController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("/Admin/Subjects/")]
        public async Task<IActionResult> Index()
        {
            var Li = await _db.ExamSubject.ToListAsync();
            return View(Li);
        }
        [HttpGet]
        [Route("/Admin/Subjects/Create")]
        public IActionResult Create()
        {
            return View(new ExamSubject());
        }
        [HttpPost]
        public async Task<IActionResult> Save(ExamSubject ExamSubject)
        {
            string d;
            if (ExamSubject.Id == 0)
            {
                await _db.ExamSubject.AddAsync(ExamSubject);
                AddNotificationToView("Added Successfully", true);
                d = "Create";
            }
            else
            {
                _db.ExamSubject.Update(ExamSubject);
                AddNotificationToView("Updated Successfully", true);
                d = "Index";
            }
            await _db.SaveChangesAsync();
            return RedirectToAction(d);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(long Id)
        {
            var Lst = await _db.ExamSubject.FindAsync(Id);
            return View("Create", Lst);
        }
    }
}
