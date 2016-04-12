using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIS411_Final_Library.Models
{
    public class Rating
    {
        public Int32 RatingID { get; set; }

        [DisplayName("User")]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [DisplayName("Book")]
        public string BookId { get; set; }

        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }


        //Rating 1-10
        [Range(1, 10, ErrorMessage = "Please enter valid rating")]
        [Required(ErrorMessage = "Rating is Required")]
        public Int32 Quantity { get; set; }

        public string Comment { get; set; }
    }
}