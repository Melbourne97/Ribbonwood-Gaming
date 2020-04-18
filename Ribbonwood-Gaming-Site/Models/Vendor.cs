using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ribbonwood_Gaming_Site.Models
{
    public class Vendor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}