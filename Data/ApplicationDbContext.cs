using EpicBookstore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EpicBookstore.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated(); // This ensures that new tables are created.
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
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
