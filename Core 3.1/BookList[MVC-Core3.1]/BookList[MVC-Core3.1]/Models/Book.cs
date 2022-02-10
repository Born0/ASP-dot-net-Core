using System.ComponentModel.DataAnnotations;

namespace BookList_MVC_Core3._1_.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
