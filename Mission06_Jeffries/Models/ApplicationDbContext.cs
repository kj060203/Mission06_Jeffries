using Microsoft.EntityFrameworkCore;
using Mission06_Jeffries.Models;

namespace Mission06_Jeffries.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Movies> Movies { get; set; }
    }
}
