using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchemesOnSKUs.Models
{
    public class SKURepository : ISKURepository
    {
        private List<SKU> _skuList;
        public SKURepository()
        {
            _skuList = new List<SKU>()
            {
                new SKU (){Id = 1, Name = "Laptop Charger",Description = "",Price=3000,SchemeCode=0,SCat=0},
                new SKU (){Id = 2, Name = "Hair Dryer",Description = "",Price=500,SchemeCode=0,SCat=0},
                new SKU (){Id = 3, Name = "Necklace",Description = "",Price=1000,SchemeCode=0,SCat=0},
                new SKU (){Id = 4, Name = "Towel",Description = "",Price=200,SchemeCode=0,SCat=0},
                new SKU (){Id = 5, Name = "Pants",Description = "",Price=2000,SchemeCode=0,SCat=0}
            };
        }
        public async Task<SKU> Add(SKU sku)
        {
            sku.Id = _skuList.Max(e => e.Id) + 1;
            _skuList.Add(sku);
            return sku;
        }

    }
}
