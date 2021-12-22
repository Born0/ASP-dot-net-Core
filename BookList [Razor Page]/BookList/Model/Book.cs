using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Model
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string  BookName { get; set; }
        public string BookAuthor { get; set; }
    }
}
