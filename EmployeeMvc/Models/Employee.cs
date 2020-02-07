using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeMvc.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public Dept dept { get; set; }
        public enum Dept
        {
            IT = 0, Accounts = 1, Insurance = 2, Healthcare = 3
        }
    }
}
