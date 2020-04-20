using Ribbonwood_Gaming_Site.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ribbonwood_Gaming_Site.ViewModels
{
    public class ProductVendorViewModel
    {
        public List<Product> Products { get; set; }
        public string Vendor { get; set; }

        public ProductVendorViewModel(List<Product> products, string vendor)
        {
            Products = products;
            Vendor = vendor;
        }

        public ProductVendorViewModel(List<Product> products)
        {
            Products = products;
        }
    }
}
