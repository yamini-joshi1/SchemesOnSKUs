using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchemesOnSKUs.Models
{
    public class SKU
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int SchemeCode { get; set; }
        public int SCat { get; set; }
    }
}
