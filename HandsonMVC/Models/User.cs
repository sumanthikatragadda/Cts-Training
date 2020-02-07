using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HandsonMVC.Models
{
    public class User
    {
        
        [Required(ErrorMessage = "enter name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "name format is incorrect")]
        public string Name { get; set; }
        [Required(ErrorMessage = "enter email")]
        [EmailAddress(ErrorMessage = "invalid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "enter dob")]
        public DateTime DOB { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "invalid mobile no")]
        public string No { get; set; }
        [Required(AllowEmptyStrings =false, ErrorMessage = "select")]
        
        public string Country { get; set; }
        [Required(ErrorMessage = "enter user name")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "enter password")]
        [RegularExpression("[a-z0-9]{6,8}", ErrorMessage = "invalid")]
        public string Password { get; set; }
    }
}
