using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class Movie
    {
        [Required]
        public int ID { get; set; }

        [StringLength(50)]
        [Required]
        public string Title { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy}")]
        public DateTime Year { get; set; }

        [Required]
        public string Director { get; set; }


    }
}