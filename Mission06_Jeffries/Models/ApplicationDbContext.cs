using Microsoft.EntityFrameworkCore;
using Mission06_Jeffries.Models;

namespace Mission06_Jeffries.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Drama" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Action" },
                new Category { CategoryID = 4, CategoryName = "Adventure" },
                new Category { CategoryID = 5, CategoryName = "Horror" },
                new Category { CategoryID = 6, CategoryName = "Thriller" },
                new Category { CategoryID = 7, CategoryName = "Sci-Fi" },
                new Category { CategoryID = 8, CategoryName = "Romance" },
                new Category { CategoryID = 9, CategoryName = "Mystery" },
                new Category { CategoryID = 10, CategoryName = "Family" }
                );
        }
    }
}
