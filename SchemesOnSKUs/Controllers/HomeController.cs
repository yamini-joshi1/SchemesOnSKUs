using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchemesOnSKUs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchemesOnSKUs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private ISKURepository _sKURepository;
        private IPrimaryCategoryRepository _primaryCategoryRepository;
        private ISecondaryCategoryRepository _secondaryCategoryRepository;
        private ISchemeRepository _schemeRepository;

        public HomeController(ISKURepository sKURepository, IPrimaryCategoryRepository primaryCategory,
            ISecondaryCategoryRepository secondaryCategory, ISchemeRepository schemeRepository)
        {
            _sKURepository = sKURepository;
            _primaryCategoryRepository = primaryCategory;
            _secondaryCategoryRepository = secondaryCategory;
            _schemeRepository = schemeRepository;
        }

        [HttpPost]
        public async Task<SKU> CreateProduct([FromBody] SKU sku)
        {
            return await _sKURepository.Add(sku);
        }
    }
}
