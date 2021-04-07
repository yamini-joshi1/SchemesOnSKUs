using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchemesOnSKUs.Models
{
    public class SecondaryCategoryRepository : ISecondaryCategoryRepository
    {
        private ISKURepository _sKURepository;
        public SecondaryCategoryRepository(ISKURepository sKURepository)
        {
            _sKURepository = sKURepository;
        }
        private List<SecondaryCategory> _secondaryCategoryList;
        public SecondaryCategoryRepository()
        {
            _secondaryCategoryList = new List<SecondaryCategory>()
            {
                new SecondaryCategory(){Id=1,SCatName="Electronic Accessories",SCatDesc="",PCat = 1,SchemeApplicable=0 },
                new SecondaryCategory(){Id=2,SCatName="Styling",SCatDesc="",PCat = 1, SchemeApplicable=0 },
                new SecondaryCategory(){Id=3,SCatName="Fashion Accessories",SCatDesc="",PCat=2, SchemeApplicable=0 },
                new SecondaryCategory(){Id=4,SCatName="Fashion Apparel",SCatDesc="",PCat=2, SchemeApplicable=0 },
                new SecondaryCategory(){Id=5,SCatName="Personal Care Items",SCatDesc="",PCat=3, SchemeApplicable=0 }
            };
        }
        public async Task<SecondaryCategory> Add(SecondaryCategory category, int[] skus)
        {
            _secondaryCategoryList.Add(category);
            await _sKURepository.UpdateSKUs(skus, category.Id);
            return category;
        }
        public async Task UpdateSCs(int[] scs, int primCat)
        {
            foreach (var sc in scs)
            {
                SecondaryCategory skuToBeUpdated = _secondaryCategoryList.FirstOrDefault(s => s.Id == sc);
                skuToBeUpdated.PCat = primCat;
            }
        }
        public async Task AddScheme(int S, int schemeCode)
        {
            SecondaryCategory sc = _secondaryCategoryList.FirstOrDefault(p => p.Id == S);
            sc.SchemeApplicable = schemeCode;
        }

        public async Task MoveSc(int S, int P)
        {
            SecondaryCategory sc = _secondaryCategoryList.FirstOrDefault(p => p.Id == S);
            sc.PCat = P;
        }
    }
}
