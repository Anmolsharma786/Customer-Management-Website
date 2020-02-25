using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Employeecs
    {

        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("First Name")]
        public string fName { get; set; }
        [Column(TypeName = "varchar(10)")]
        [DisplayName("Last Name")]
        public string lName { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Gender Name")]
        public string gender { get; set; }
        [Column(TypeName = "varchar(100)")]
        public int JobId { get; set; }

    }
}
