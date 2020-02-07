using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Validations.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="enter id")]
        [DisplayName("Employee Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "enter name")]
        [StringLength(maximumLength:20,MinimumLength =4,ErrorMessage ="name format is incorrect")]
        public string Name { get; set; }
        [Required(ErrorMessage = "enter email")]
        [EmailAddress(ErrorMessage ="Employee Id")]
        public string Email { get; set; }
        
        [RegularExpression(@"[6-9]\d{9}",ErrorMessage ="invalid mobile no")]
        public int Mobile { get; set; }
        [Required(ErrorMessage = "enter user name")]
        
        public string Uname { get; set; }
        [Required(ErrorMessage = "enter password")]
        [RegularExpression("[a-z0-9]{6,8}",ErrorMessage ="invalid")]
        public string Pwd { get; set; }
        [Compare("Pwd", ErrorMessage = "password mismatch")]
        public string Cpwd { get; set; }
    }
}
