using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchemesOnSKUs.Models
{
    public class SchemeRepository : ISchemeRepository
    {
        private ISKURepository _sKURepository;
        private ISecondaryCategoryRepository _secondaryCategoryRepository;
        private IPrimaryCategoryRepository _primaryCategoryRepository;

        public SchemeRepository(ISKURepository sKURepository,
            ISecondaryCategoryRepository secondaryCategoryRepository, 
            IPrimaryCategoryRepository primaryCategoryRepository)
        {
            _sKURepository = sKURepository;
            _secondaryCategoryRepository = secondaryCategoryRepository;
            _primaryCategoryRepository = primaryCategoryRepository;
        }

        private List<Scheme> _schemesList;
        public SchemeRepository()
        {
            _schemesList = new List<Scheme>()
            {
               new Scheme(){SchemeCode=1,SchemeType="D",SchemeQty=8,FreeQty=2,SchemeAmt=0,SKUId=0},
               new Scheme(){SchemeCode=2,SchemeType="A",SchemeQty=0,FreeQty=1,SchemeAmt=5000,SKUId=3},
            };
        }
        public async Task<Scheme> Add(Scheme scheme, int P, int S, int sku)
        {
            _schemesList.Add(scheme);
            await _sKURepository.AddScheme(sku, scheme.SchemeCode);
            await _secondaryCategoryRepository.AddScheme(S, scheme.SchemeCode);
            await _primaryCategoryRepository.AddScheme(P, scheme.SchemeCode);
            return scheme;
        }
    }
}
