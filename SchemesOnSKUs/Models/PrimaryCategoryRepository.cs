using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchemesOnSKUs.Models
{
    public class PrimaryCategoryRepository : IPrimaryCategoryRepository
    {
        private ISecondaryCategoryRepository _secondaryCategoryRepository;
        public PrimaryCategoryRepository(ISecondaryCategoryRepository secondaryCategoryRepository)
        {
            _secondaryCategoryRepository = secondaryCategoryRepository;
        }
        private List<PrimaryCategory> _primaryCategoryList;
        public PrimaryCategoryRepository()
        {
            _primaryCategoryList = new List<PrimaryCategory>()
            {
                new PrimaryCategory(){Id=1,PCatName="Electronics",PCatDesc="",SchemeApplicable=0 },
                new PrimaryCategory(){Id=2,PCatName="Fashion",PCatDesc="",SchemeApplicable=0 },
                new PrimaryCategory(){Id=3,PCatName="Personal Care",PCatDesc="",SchemeApplicable=0 },
            };
        }
        public async Task<PrimaryCategory> Add(PrimaryCategory category, int[] subCategories)
        {
            _primaryCategoryList.Add(category);
            await _secondaryCategoryRepository.UpdateSCs(subCategories, category.Id);
            return category;
        }

        public async Task AddScheme(int P, int schemeCode)
        {
            PrimaryCategory pc = _primaryCategoryList.FirstOrDefault(p => p.Id == P);
            pc.SchemeApplicable = schemeCode;
        }
    }
}
