using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ribbonwood_Gaming_Site.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string Status { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}