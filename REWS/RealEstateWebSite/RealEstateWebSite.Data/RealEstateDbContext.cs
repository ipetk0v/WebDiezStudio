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

        DbSet<Broker> Brokers { get; set; }
        DbSet<Estate> Estaties { get; set; }
        DbSet<User> User { get; set; }
        DbSet<Agency> Agency { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<User>()
                .HasMany(u => u.Estaties)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            builder
                .Entity<Agency>()
                .HasMany(a => a.Brokers)
                .WithOne(b => b.Agency)
                .HasForeignKey(b => b.AgencyId);

            builder
                .Entity<AgencyEstate>()
                .HasOne(ae => ae.Agency)
                .WithMany(a => a.AgencyEstate)
                .HasForeignKey(a => a.AgencyId);

            builder
                .Entity<AgencyEstate>()
                .HasOne(ae => ae.Estate)
                .WithMany(e => e.AgencyEstate)
                .HasForeignKey(e => e.EstateId);

            base.OnModelCreating(builder);
        }
    }
}
