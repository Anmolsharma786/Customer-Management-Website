using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace CRUD.Models
{
    public class JobPostingContext : DbContext
    {
        public JobPostingContext(DbContextOptions<JobPostingContext> options) : base(options) { }
        public DbSet<JobPosting> JobPostings { get; set; }
    }
}
