using ECommerceDataAccess.Abstract;
using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceDataAccess.Concrete
{
    public class DistrictRepository : Repository<District>, IDistrict
    {
        private EComerceDBAccess _eComerceDBAccess;
        public DistrictRepository(EComerceDBAccess eComerceDBAccess) : base(eComerceDBAccess)
        {
            _eComerceDBAccess = eComerceDBAccess;
        }
    }
}
