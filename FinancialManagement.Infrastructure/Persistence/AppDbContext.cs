using FinancialManagement.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinancialManagement.Infrastructure.Persistence
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> DBContext) : base(DBContext) { }
        public DbSet<Users> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Users>(user =>
            {
                user.OwnsOne(p => p.Age);
                user.Property(p => p.Role).HasConversion<string>();
            });
        }
    }
}
