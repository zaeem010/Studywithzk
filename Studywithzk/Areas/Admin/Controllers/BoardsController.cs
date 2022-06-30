using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class BoardsController : BaseController
    {
        private readonly ApplicationDbContext _db;
        public BoardsController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var Li = await _db.Boards
                .Include(z => z.Countrys)
                .Include(z => z.States)
                .ToListAsync();
            return View(Li);
        }
        [HttpGet]
        public IActionResult Create(Boards Boards)
        {
            IEnumerable<SelectListItem> CountryList = _db.Countrys.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.CountryName
            });
            var VM = new BoardVM 
            {
                CountryList= CountryList,
                Boards= Boards
            };
            return View(VM);
        }
        [HttpGet]
        public async Task<IActionResult> GetState(long CountryId) 
        {
            var Li = await _db.States.Where(c => c.CountrysId == CountryId).ToListAsync();
            return Json(Li);
        }
        [HttpPost]
        public async Task<IActionResult> Save(Boards Boards) 
        {
            string d;
            if (Boards.Id == 0)
            {
                await _db.Boards.AddAsync(Boards);
                d = "Create";
                AddNotificationToView("Registered Successfully", true);
            }
            else 
            {
                _db.Boards.Update(Boards);
                d = "Index";
                AddNotificationToView("Updated Successfully", true);
            }
            await _db.SaveChangesAsync();
            return RedirectToAction(d);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(long Id) 
        {
            IEnumerable<SelectListItem> CountryList = _db.Countrys.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.CountryName
            });
            var Boards = await _db.Boards.SingleOrDefaultAsync(c=>c.Id.Equals(Id));
            var VM = new BoardVM
            {
                CountryList = CountryList,
                Boards = Boards
            };
            return View("Create",VM);
        }
    }
}
