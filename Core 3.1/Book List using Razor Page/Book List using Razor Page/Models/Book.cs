using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Book_List_using_Razor_Page.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required(ErrorMessage = "Name can't be Empty")]
        [Display(Name = "Book Name")]
        public string BookName { get; set; }
        [Display(Name = "Book Author")]
        public string BookAuthor { get; set; }
        public string ISBN { get; set; }
    }
}
