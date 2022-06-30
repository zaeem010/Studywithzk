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
    public class ExamYearController : BaseController
    {
        private readonly ApplicationDbContext _db;
        public ExamYearController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("/Admin/Years/")]
        public async Task<IActionResult> Index()
        {
            var Li = await _db.ExamYear.ToListAsync();
            return View(Li);
        }
        [HttpGet]
        [Route("/Admin/Years/Create")]
        public IActionResult Create()
        {
            return View(new ExamYear());
        }
        [HttpPost]
        public async Task<IActionResult> Save(ExamYear ExamYear)
        {
            string d;
            if (ExamYear.Id == 0)
            {
                await _db.ExamYear.AddAsync(ExamYear);
                AddNotificationToView("Added Successfully", true);
                d = "Create";
            }
            else
            {
                _db.ExamYear.Update(ExamYear);
                AddNotificationToView("Updated Successfully", true);
                d = "Index";
            }
            await _db.SaveChangesAsync();
            return RedirectToAction(d);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(long Id)
        {
            var Lst = await _db.ExamYear.FindAsync(Id);
            return View("Create", Lst);
        }
    }
}
