using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        //accepts ###-#########
        [RegularExpression("([0-9]{3})+-+([0 - 9]{10})", ErrorMessage="Incorrect ISBN format")]
        public int ISBN { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        //Split out the name
        public string AuthorFirstName { get; set; }
        public string AuthorMiddleName { get; set; }
        [Required]
        public string AuthorLastName { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        //split category and classfication
        public string Category { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
