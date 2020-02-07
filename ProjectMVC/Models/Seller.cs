using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;


namespace ProjectMVC.Models
{
    public class Seller
    {

        [Key]
        [Required(ErrorMessage = "enter id")]
        [DisplayName("Seller Id")]
        public int Sid { get; set; }
        [Required(ErrorMessage = "enter name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "name format is incorrect")]

        public string Sname { get; set; }
        public string Companyname { get; set; }
        [Required(ErrorMessage = "enter email")]
        [EmailAddress(ErrorMessage = "email invalid")]
        public string Website { get; set; }
        [Required(ErrorMessage = "enter email")]
        [EmailAddress(ErrorMessage = "email invalid")]
        public string Semail { get; set; }
        [Required(ErrorMessage = "enter password")]
        [RegularExpression("[a-z0-9]{6,8}", ErrorMessage = "invalid")]
        public string Spassword { get; set; }
        public string Saddress { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "invalid mobile no")]
        public int Contactno { get; set; }
        public string Photopath { get; set; }
        

      
        
        public Seller()
        {

        }

        public Seller(int Sid, string Sname, string Spassword, string Companyname, string Saddress, string Website, string Semail, int Contactno, string Photopath)
        {
            this.Sid = Sid;
            this.Sname = Sname;
            this.Spassword = Spassword;
            this.Companyname = Companyname;
            this.Saddress = Saddress;
            this.Website = Website;
            this.Semail = Semail;
            this.Contactno = Contactno;
            this.Photopath = Photopath;
        }
    }
}
