using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchemesOnSKUs.Models
{
    public interface ISKURepository
    {
        Task<SKU> Add(SKU sku);
        Task UpdateSKUs(int[] skus, int subCat);
        Task AddScheme(int sku, int schemeCode);
    }
}
