using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchemesOnSKUs.Models
{
    public interface IPrimaryCategoryRepository
    {
        Task<PrimaryCategory> Add(PrimaryCategory category, int[]subCategories);
        Task AddScheme(int P, int schemeCode);
    }
}
