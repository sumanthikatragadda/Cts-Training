using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeMvc.Models;

namespace EmployeeMvc.Data
{
    public class EmployeeMvcContext : DbContext
    {
        public EmployeeMvcContext (DbContextOptions<EmployeeMvcContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeMvc.Models.Employee> Employee { get; set; }
    }
}
