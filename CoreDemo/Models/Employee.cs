using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;


namespace CoreDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "max is 10")]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "invalid")]
        [DisplayName(" mail")]
        [ValidateDomain(allowDomain:"cts.com")]
        [Remote(action:"IsEmailExist",controller:"Employee")]
        public string Email { get; set; }
        [Required]
        public Dept dept { get; set; }
        //public enum Dept
        //{
        //    IT=0, Accounts=1, Insurance=2, Healthcare=3
        //}

        public Employee()
        {

        }
        public Employee(int Id, string Name, string Email, Dept dept)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.dept = dept;
        }

    }
}
