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
    public class UnSolvedPaperVM
    {
        public IEnumerable<SelectListItem> CountryList { get; set; }
        public IEnumerable<SelectListItem> YearList { get; set; }
        public IEnumerable<SelectListItem> ClassList { get; set; }
        public IEnumerable<SelectListItem> SubjectList { get; set; }
        public UnsolvedPaper UnsolvedPaper { get; set; }
    }
}
