using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Google_ReCaptcha_Tutorial.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Grade { get; set; }
        public string Address { get; set; }
    }
}