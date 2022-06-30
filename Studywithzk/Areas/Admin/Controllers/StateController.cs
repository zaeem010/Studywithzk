using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Studywithzk.Data;
using Studywithzk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studywithzk.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StateController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StateController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var Li = await _db.States
                .Include(z=>z.Countrys)
                .ToListAsync();
            return View(Li);
        }
        public async Task<IActionResult> Save(IFormCollection form)
        {
            var Request = form["myRequest"];
            var States = JsonConvert.DeserializeObject<List<States>>(Request);

            await _db.States.AddRangeAsync(States);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
