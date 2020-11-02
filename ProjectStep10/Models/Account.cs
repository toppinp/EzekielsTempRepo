using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStep10.Models
{
    public class Account
    {
        // F i e l d s   &   P r o p e r t i e s

        public int userId { get; set; }

        [Required(ErrorMessage="Name Is Required")]
        public string name { get; set; }

        [Required(ErrorMessage = "Phone Is Required")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Street Address Is Required")]
        public string streetAddress { get; set; }

        [Required(ErrorMessage = "City Is Required")]
        public string city { get; set; }

        [Required(ErrorMessage = "Email Is Required")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        public string password { get; set; }

        [Required(ErrorMessage = "The Passwords Must Match")]
        public string confirmPassword { get; set; }

        // C o n s t u c t o r s


        // M e t h o d s 


    }
}
