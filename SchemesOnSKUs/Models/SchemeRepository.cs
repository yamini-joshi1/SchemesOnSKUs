using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchemesOnSKUs.Models
{
    public class SchemeRepository : ISchemeRepository
    {
        private List<Scheme> _schemesList;
        public SchemeRepository()
        {
            _schemesList = new List<Scheme>()
            {
               new Scheme(){SchemeCode=1,SchemeType="D",SchemeQty=8,FreeQty=2,SchemeAmt=0,SKUId=0},
               new Scheme(){SchemeCode=2,SchemeType="A",SchemeQty=0,FreeQty=1,SchemeAmt=5000,SKUId=3},
            };
        }
        public async Task<Scheme> Add(Scheme scheme)
        {
            _schemesList.Add(scheme);
            return scheme;
        }
    }
}
