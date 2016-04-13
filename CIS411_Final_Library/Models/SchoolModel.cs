using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIS411_Final_Library.Models
{
    [Table("VoteLog")]
    public class SchoolModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoId {get; set;}
        public int VoteForId { get; set; }
        public string UserName { get; set; }
        public Int16 Vote { get; set; }
        public bool Active { get; set; }
    }
}