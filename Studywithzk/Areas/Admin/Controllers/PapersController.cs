using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Studywithzk.Data;
using Studywithzk.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Studywithzk.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PapersController : BaseController
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment host;
        public PapersController(ApplicationDbContext db, IWebHostEnvironment host)
        {
            _db = db;
            this.host = host;
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
        [HttpGet]
        public async Task<IActionResult> GetBoard(long BoardsId)
        {
            var Li = await _db.Boards.Where(c => c.StatesId == BoardsId).ToListAsync();
            return Json(Li);
        }
        [HttpPost]
        public async Task<IActionResult> Save(UnsolvedPaper UnsolvedPaper)
        {
            Random r = new Random();
            int num = r.Next();
            string d,CustomfileName = "_a";
            var webrootpath = host.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            //Image Insert
            if (files.Count > 0)
            {
                var uploads = Path.Combine(webrootpath, "Papers");
                var Ext = Path.GetExtension(files[0].FileName);
                using (var stream = new FileStream(Path.Combine(uploads,num + CustomfileName + Ext), FileMode.Create))
                {
                    files[0].CopyTo(stream);
                }
                UnsolvedPaper.RegisterDate = DateTime.Now;
                UnsolvedPaper.PaperPath = num + CustomfileName + Ext;
               
            }
            if (UnsolvedPaper.Id == 0)
            {
                await _db.UnsolvedPaper.AddAsync(UnsolvedPaper);
                AddNotificationToView("Uploaded Successfully", true);
                d = "Create";
            }
            else 
            {
                _db.UnsolvedPaper.Update(UnsolvedPaper);
                d = "Index";
            }
            await _db.SaveChangesAsync();
            return RedirectToAction(d);
        }

    }
}
