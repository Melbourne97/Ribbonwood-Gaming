﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ribbonwood_Gaming_Site.Models
{
    public class Product
    {
        public int ID { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public Vendor Vendor { get; set; }

    }
}