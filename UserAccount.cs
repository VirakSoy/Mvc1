using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP_MVC1.Models;
using System.ComponentModel.DataAnnotations;
namespace ASP_MVC1.Models
{
    public class UserAccount
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Required field")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required field")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required field")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Required field")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3]\.)|(([\w-]+\.)+))([a-zA-Z{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter valid email.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Required field")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Compare("Password",ErrorMessage ="noob")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}