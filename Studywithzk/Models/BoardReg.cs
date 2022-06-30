using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Studywithzk.Models
{
    public class Countrys
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(455)]
        public string CountryName { get; set; }
        [MaxLength(255)]
        public string Countrycode { get; set; }
    }
    public class States
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(455)]
        public string StatesName { get; set; }
        public long CountrysId { get; set; }
        public virtual Countrys Countrys { get; set; }
    }
    public class Boards
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(455)]
        [Required(ErrorMessage ="Board Name is Required")]
        public string BoardName { get; set; }
        [Required(ErrorMessage = "Country is Required")]
        public long CountrysId { get; set; }
        [Required(ErrorMessage = "State is Required")]
        public long StatesId { get; set; }
        public virtual States States { get; set; }
        public virtual Countrys Countrys { get; set; }
    }
    public class ExamClass
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(455)]
        [Required(ErrorMessage = "class Name is Required")]
        public string className { get; set; }

        [Required(ErrorMessage = "Country is Required")]
        public long CountrysId { get; set; }
        [Required(ErrorMessage = "State is Required")]
        public long StatesId { get; set; }
        [Required(ErrorMessage = "Boards is Required")]
        public long BoardsId { get; set; }
        public virtual States States { get; set; }
        public virtual Boards Boards { get; set; }
        public virtual Countrys Countrys { get; set; }
    }
}
