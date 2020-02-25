using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class EmployeeContext : DbContext
    {
       public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }
       public DbSet<Employeecs> Employees { get; set; }
    }
}
