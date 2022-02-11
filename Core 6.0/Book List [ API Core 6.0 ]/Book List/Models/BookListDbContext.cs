using Microsoft.EntityFrameworkCore;

namespace Book_List.Models
{
    public class BookListDbContext:DbContext
    {
        public BookListDbContext(DbContextOptions<BookListDbContext> options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
