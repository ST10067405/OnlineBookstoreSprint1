using EpicBookstore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EpicBookstore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated(); // This ensures that new tables are created.
        }

        public DbSet<AddressModel> Address { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<CartModel> Cart { get; set; }
        public DbSet<ItemModel> Item { get; set; }
        public DbSet<LogAttemptModel> LogAttempt { get; set; }
        public DbSet<OrderItemModel> OrderItem { get; set; }
        public DbSet<OrderModel> Order { get; set; }
        public DbSet<SearchLogModel> SearchLog { get; set; }

    }
}
