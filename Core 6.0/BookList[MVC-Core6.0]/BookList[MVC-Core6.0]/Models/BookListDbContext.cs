using Microsoft.EntityFrameworkCore;

namespace BookList_MVC_Core6._0_.Models.Models
{
    public class BookListDbContext:DbContext
    {
        public BookListDbContext(DbContextOptions<BookListDbContext> options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
