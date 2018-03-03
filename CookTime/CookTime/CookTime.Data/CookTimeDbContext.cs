using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CookTime.Data.Models;

namespace CookTime.Data
{
    public class CookTimeDbContext : DbContext
    {
        public CookTimeDbContext(DbContextOptions<CookTimeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipe { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
