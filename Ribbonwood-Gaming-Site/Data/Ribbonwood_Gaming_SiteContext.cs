using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ribbonwood_Gaming_Site.Models;

namespace Ribbonwood_Gaming_Site.Data
{
    public class Ribbonwood_Gaming_SiteContext : DbContext
    {
        public Ribbonwood_Gaming_SiteContext (DbContextOptions<Ribbonwood_Gaming_SiteContext> options)
            : base(options)
        {
        }

        public DbSet<Ribbonwood_Gaming_Site.Models.Product> Product { get; set; }
    }
}
