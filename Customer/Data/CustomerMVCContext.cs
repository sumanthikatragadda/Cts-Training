using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerMVC.Models;

namespace CustomerMVC.Data
{
    public class CustomerMVCContext : DbContext
    {
        public CustomerMVCContext (DbContextOptions<CustomerMVCContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerMVC.Models.Customer> Customer { get; set; }
    }
}
