using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class JobPosting
    {
        [Key]
        public int JobId { get; set; }
        [Required]
        [DisplayName("Experience")]
        [Column(TypeName = "nvarchar(250)")]
        public string Experience { get; set; }
        [Column(TypeName = "date")]
        [DisplayName("Starting Date")]
        public DateTime startingDate { get; set; }
        [Column(TypeName = "date")]
        [DisplayName("Ending Date")]
        public DateTime endingDate { get; set; }

        public string JobDescription { get; set; }
    }
}
