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
    public class Checkout
    {
        public Int32 CheckoutID { get; set; }

        [DisplayName("User")]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [DisplayName("Book")]
        public string BookId { get; set; }

        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Checkout Date")]
        public DateTime CheckoutDate { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        public Int32 Quantity { get; set; }


        //need to make a method here or in controller to assign a default value based off checkout date
        //when a new record is saved
        [DataType(DataType.DateTime)]
        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }


    }
}