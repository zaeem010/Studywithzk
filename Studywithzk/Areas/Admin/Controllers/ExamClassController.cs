using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studywithzk.Areas.Admin.Controllers
{
    public class ExamClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
