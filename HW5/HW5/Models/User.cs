using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HW5.Models
{
    public class User
    {
        public int ID { get; set; }

        [Display(Name = "First Name"), Required]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DOB { get; set; }

        [Required, DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }

        public string Phone { get; set; }

        public int C_Year { get; set; }

        public string Email { get; set; }

        public string Major { get; set; }

        public string Minor { get; set; }

        public string Advisor { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}: {FirstName} {LastName} DOB = {DOB}";
        }
    }
}