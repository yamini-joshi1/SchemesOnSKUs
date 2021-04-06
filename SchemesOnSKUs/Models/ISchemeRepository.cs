using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchemesOnSKUs.Models
{
    public interface ISchemeRepository
    {
        Task<Scheme> Add(Scheme scheme);
    }
}
