using Microsoft.EntityFrameworkCore;

namespace Mission11_Humphrey.Models
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext (DbContextOptions<BookstoreContext> options) : base(options) { }

        public DbSet<Bookstore> Books { get; set; }
    }
}
