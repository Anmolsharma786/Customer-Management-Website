using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class ProjectRunning
    {

        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("Project DeadLine")]
        public string projectDeadline { get; set; }
        [Column(TypeName = "varchar(10)")]
        [DisplayName("Project Manager")]
        public string ProjectManager { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }
        [Column(TypeName = "varchar(100)")]
        public int ProjectId { get; set; }
    }
}
