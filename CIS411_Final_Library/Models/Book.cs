using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CIS411_Final_Library.Models
{
    public class Book
    {
        public Int32 BookID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(50, ErrorMessage = "Title cannot be longer than 50 characters.")]
        [DisplayName("Book Title")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Authored Date")]
        public DateTime CreationDate { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        public Int32 Quantity { get; set; }


    }
}