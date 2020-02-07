using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomerMVC.Models
{
    public class Customer
    {
        public int Id { get; set; }
        //[Required]
        public string Name { get; set; }
        //[Required]
        public string Email { get; set; }
        public int Amount { get; set; }
        public Customer()
        {

        }
        public Customer(int Id,string Name,string Email,int Amount)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Amount = Amount;
        }
    }
    
}
