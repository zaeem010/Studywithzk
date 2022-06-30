using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studywithzk.Models
{
    public class BoardVM
    {
        public IEnumerable<SelectListItem> CountryList { get; set; }
        public Boards Boards { get; set; }
    }
}
