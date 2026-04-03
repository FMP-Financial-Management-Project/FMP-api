using FinancialManagement.Domain.Entities;
using FinancialManagement.Domain.ObjectValue;
using FinancialManagement.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinancialManagement.Infrastructure.Persistence
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Users> Users { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Users>(user =>
            {
                user.HasKey(u => u.Id);
                user.ToTable("DomainUsers");

                user.Property(p => p.Name)
                    .HasMaxLength(150)
                    .IsRequired();

                user.Property(p => p.Age)
                    .HasConversion(
                    ageUser => ageUser.Value,
                    value => AgeUser.Create(value));

                user.Property(p => p.Role)
                    .HasConversion<string>();
            });
        }
    }
}
