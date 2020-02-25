using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Customers
    {

        [Key]
        public int customerId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("First Name")]
        public string fname { get; set; }
        [Column(TypeName = "varchar(10)")]
        [DisplayName("Last Name")]
        public string lname { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Country")]
        public string country { get; set; }
        [Column(TypeName = "varchar(100)")]
        public int ProjectId { get; set; }
    }
}
