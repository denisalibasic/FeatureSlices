using Microsoft.EntityFrameworkCore;

namespace FeatureSlices.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "The Hobbit", Author = "J.R.R. Tolkien" },
                new Book { Id = 2, Title = "1984", Author = "George Orwell" }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Inception", Director = "Christopher Nolan" },
                new Movie { Id = 2, Title = "The Matrix", Director = "Lana Wachowski, Lilly Wachowski" }
            );
        }
    }
}
