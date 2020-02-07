using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationDemo.Models
{
    public class UserAccount
    { 
        [Key]
        public string Name { get; set; }
        //[DataType Password]
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }


    }
}
