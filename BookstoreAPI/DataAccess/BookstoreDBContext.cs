using BookstoreAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookstoreAPI.DataAccess
{
    public class BookstoreDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public BookstoreDBContext(DbContextOptions<BookstoreDBContext> options) : base(options) { }
    }
}
