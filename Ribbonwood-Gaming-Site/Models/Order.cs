using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ribbonwood_Gaming_Site.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }

        // Navigation Properties
        public int UserID { get; set; }
        public User User { get; set; }
    }
}