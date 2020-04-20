using Microsoft.EntityFrameworkCore;
using Ribbonwood_Gaming_Site.Models;

namespace Ribbonwood_Gaming_Site.Data
{
    public class RibbonwoodContext : DbContext
    {
        public RibbonwoodContext(DbContextOptions<RibbonwoodContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
