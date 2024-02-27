using EpicBookstore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EpicBookstore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated(); // This ensures that new tables are created.
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50); // adjust length as needed

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50); // adjust length as needed
            });
        }

        public DbSet<AddressModel> Address { get; set; }
        public DbSet<CartModel> Cart { get; set; }
        public DbSet<ItemModel> Item { get; set; }
        public DbSet<LogAttemptModel> LogAttempt { get; set; }
        public DbSet<OrderItemModel> OrderItem { get; set; }
        public DbSet<OrderModel> Order { get; set; }
        public DbSet<SearchLogModel> SearchLog { get; set; }

    }
}
