using ECommerceDataAccess.Abstract;
using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceDataAccess.Concrete
{
    public class SaleRepository : Repository<Sale>, ISale
    {
        private EComerceDBAccess _eComerceDBAccess;
        public SaleRepository(EComerceDBAccess eComerceDBAccess) : base(eComerceDBAccess)
        {
            _eComerceDBAccess = eComerceDBAccess;
        }
    }
}
