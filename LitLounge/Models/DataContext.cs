using Microsoft.EntityFrameworkCore;

namespace LitLounge.Models
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<PublishingHouse> PublishingHouses { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
