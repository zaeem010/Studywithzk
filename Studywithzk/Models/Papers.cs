using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Studywithzk.Models
{
    public class Papers
    {
        [Key]
        public long Id { get; set; }
        [Required (ErrorMessage ="Select Country")]
        public long CountrysId { get; set; }
        [Required(ErrorMessage = "Select State")]
        public long StatesId { get; set; }
        [Required(ErrorMessage = "Select Board")]
        public long BoardsId { get; set; }
        [Required(ErrorMessage = "Select Class")]
        public long ExamClassId { get; set; }
        [Required(ErrorMessage = "Select Year")]
        public long ExamYearId { get; set; }
        [Required(ErrorMessage = "Select Subject")]
        public long ExamSubjectId { get; set; }
        [Required(ErrorMessage = "Enter Papers Details...")]
        public string UnSolved { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool Verify { get; set; }
    }
}
