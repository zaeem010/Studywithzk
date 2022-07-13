using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Studywithzk.Models
{
    public class UnsolvedPaper
    {
        [Key]
        public long Id { get; set; }
        [Required (ErrorMessage ="Select Country")]
        public long CountrysId { get; set; }
        [Required(ErrorMessage = "Select State")]
        public long StatesId { get; set; }
        [Required(ErrorMessage = "Select Board")]
        public long BoardsId { get; set; }
        [Required(ErrorMessage = "Select Year")]
        public long ExamYearId { get; set; }
        [Required(ErrorMessage = "Select Class")]
        public long ExamClassId { get; set; }
        [Required(ErrorMessage = "Select Subject")]
        public long ExamSubjectId { get; set; }
        [Required(ErrorMessage = "Enter Papers Details...")]
        public string UnSolved { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool Verify { get; set; }
       //
        public virtual Countrys Countrys { get; set; }
        public virtual States States { get; set; }
        public virtual Boards Boards { get; set; }
        public virtual ExamYear ExamYear { get; set; }
        public virtual ExamClass ExamClass { get; set; }
        public virtual ExamSubject ExamSubject { get; set; }
    }
}
