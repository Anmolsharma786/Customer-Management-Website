using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Salarys
    {
        [DisplayName("Starting Date")]
        public DateTime startingDate { get; set; }
        [DisplayName("Ending Date")]
        [Required]
        public DateTime endingDate { get; set; }
        [Required]
        [DisplayName("Salary")]
        public int salary { get; set; }
        [Required]
        [Key]
        public int salaryId { get; set; }
        [Required]
        [DisplayName("Employee ID")]
        public int emp_id { get; set; }
    }
}
