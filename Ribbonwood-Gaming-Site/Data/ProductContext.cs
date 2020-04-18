using Microsoft.EntityFrameworkCore;
using Ribbonwood_Gaming_Site.Models;

namespace Ribbonwood_Gaming_Site.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Movie { get; set; }
    }
}
