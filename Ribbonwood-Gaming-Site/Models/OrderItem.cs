using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ribbonwood_Gaming_Site.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Quanitity { get; set; }
    }
}