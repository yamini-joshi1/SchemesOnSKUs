using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchemesOnSKUs.Models
{
    public class SecondaryCategory
    {
        public int Id { get; set; }
        public string SCatName { get; set; }
        public string SCatDesc { get; set; }
        public int SchemeApplicable { get; set; }
        public int PCat { get; set; }
    }
}
