using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchemesOnSKUs.Models
{
    public class Scheme
    {
        public int SchemeCode { get; set; }
        public string SchemeType { get; set; }
        public int SchemeQty { get; set; }
        public int FreeQty { get; set; }
        public double SchemeAmt { get; set; }
        public int SKUId { get; set; }
    }
}
