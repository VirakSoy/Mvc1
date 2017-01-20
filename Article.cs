using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ASP_MVC1.Models;

namespace ASP_MVC1.Models
{
    public class Article
    {
        [Key]
        public int articleID { get; set; }

      //  public int UserID { get; set; }

        [Required(ErrorMessage = "Required field")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Required field")]
        public DateTime date { get; set; }

        [Required(ErrorMessage = "Required field")]
        public string text { get; set; }
    }
}