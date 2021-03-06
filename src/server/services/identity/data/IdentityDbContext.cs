using Microsoft.EntityFrameworkCore;

namespace Ncc.China.Services.Identity.Data
{
    public class IdentityDbContext : DbContext
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
            : base(options)
        {
        }

        public DbSet<LoginUser> LoginUsers { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginUser>()
                .HasKey(u => u.Id)
                .HasName("pk_id");

            modelBuilder.Entity<UserProfile>()
                .HasKey(u => u.Id)
                .HasName("pk_id");
        }
    }
}
