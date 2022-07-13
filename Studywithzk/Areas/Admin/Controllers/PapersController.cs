using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Studywithzk.Data;
using Studywithzk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studywithzk.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PapersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PapersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            IEnumerable<SelectListItem> CountryList = _db.Countrys.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.CountryName
            });
            IEnumerable<SelectListItem> YearList = _db.ExamYear.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.YearName
            });
            IEnumerable<SelectListItem> ClassList = _db.ExamClass.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.className
            });
            IEnumerable<SelectListItem> SubjectList = _db.ExamSubject.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.SubjectName
            });
            var VM = new UnSolvedPaperVM 
            {
                CountryList=CountryList,
                YearList=YearList,
                ClassList=ClassList,
                SubjectList=SubjectList,
                UnsolvedPaper= new UnsolvedPaper(),
            };
            return View(VM);
        }
    }
}
