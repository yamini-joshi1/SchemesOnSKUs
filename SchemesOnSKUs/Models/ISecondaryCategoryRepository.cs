using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchemesOnSKUs.Models
{
    public interface ISecondaryCategoryRepository
    {
        Task<SecondaryCategory> Add(SecondaryCategory category, int[] skus);
        Task UpdateSCs(int[] skus, int subCat);
        Task AddScheme(int S, int schemeCode);
    }
}
