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
        public string UnSolved { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool Verify { get; set; }
        public string PaperPath { get; set; }
       //
        public virtual Countrys Countrys { get; set; }
        public virtual States States { get; set; }
        public virtual Boards Boards { get; set; }
        public virtual ExamYear ExamYear { get; set; }
        public virtual ExamClass ExamClass { get; set; }
        public virtual ExamSubject ExamSubject { get; set; }
        public virtual List<PapersExtraLink> PapersExtraLink { get; set; }
        public UnsolvedPaper()
        {
            PapersExtraLink = new List<PapersExtraLink>();
        }
    }
    public class PapersExtraLink 
    {
        [Key]
        public long Id { get; set; }
        public long UnsolvedPaperId { get; set; }
        [MaxLength(255)]
        public string Title { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        [MaxLength(455)]
        public string PathLink { get; set; }
    }
}
