using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ribbonwood_Gaming_Site.Models;

namespace Ribbonwood_Gaming_Site.ViewModels
{
    public class OrderViewModel
    {
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
