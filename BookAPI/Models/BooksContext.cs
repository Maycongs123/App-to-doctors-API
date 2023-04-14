using Microsoft.EntityFrameworkCore;

namespace BookAPI.Models
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Books> Books { get; set; }

    }
}
