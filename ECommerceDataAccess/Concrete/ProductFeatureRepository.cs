using ECommerceDataAccess.Abstract;
using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceDataAccess.Concrete
{
    public class ProductFeatureRepository : Repository<ProductFeature>, IProductFeature
    {
        private EComerceDBAccess _eComerceDBAccess;
        public ProductFeatureRepository(EComerceDBAccess eComerceDBAccess) : base(eComerceDBAccess)
        {
            _eComerceDBAccess = eComerceDBAccess;
        }
    }
}
