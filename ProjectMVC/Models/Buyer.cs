using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProjectMVC.Models
{
    public class Buyer
    {
        [Key]
        [Required(ErrorMessage = "enter id")]
        [DisplayName("Buyer Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "enter name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "name format is incorrect")]
        public string Name { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "enter email")]
        [EmailAddress(ErrorMessage = "email invalid")]
        public string Mail { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "invalid mobile no")]
        public int Phoneno { get; set; }
        [Required(ErrorMessage = "enter password")]
        [RegularExpression("[a-z0-9]{6,8}", ErrorMessage = "invalid")]
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public Buyer()
        {

        }

        public Buyer(int Id, string Name, string Address, string Mail, int Phoneno, string Password, DateTime CreatedDate)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.Mail = Mail;
            this.Phoneno = Phoneno;
            this.Password = Password;
            this.CreatedDate = CreatedDate;
        }
    }
}
