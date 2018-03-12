using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstateWebSite.Data.Models;
using RealEstateWebSite.Models;

namespace RealEstateWebSite.Data
{
    public class RealEstateDbContext : IdentityDbContext<User>
    {
        public RealEstateDbContext(DbContextOptions<RealEstateDbContext> options)
            : base(options)
        {
        }

        DbSet<Estate> Estaties { get; set; }
        DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<User>()
                .HasMany(u => u.Estaties)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            base.OnModelCreating(builder);
        }
    }
}
