using BookAtticWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAtticWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
