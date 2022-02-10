using Microsoft.EntityFrameworkCore;

namespace BookList_MVC_Core3._1_.Models
{
    public class BookListDbContext:DbContext
    {
        public BookListDbContext(DbContextOptions<BookListDbContext> options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
