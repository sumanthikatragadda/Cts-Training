using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Validations.Models
{
    public class Login
    {
        [Required(ErrorMessage ="name is required")]
        [DisplayName("Uname")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "passoword is required")]
        public string Pwd { get; set; }

    }
}
