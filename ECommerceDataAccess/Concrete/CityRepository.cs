using ECommerceDataAccess.Abstract;
using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceDataAccess.Concrete
{
    public class CityRepository : Repository<City>, ICity
    {
        private EComerceDBAccess _eComerceDBAccess;
        public CityRepository(EComerceDBAccess eComerceDBAccess) : base(eComerceDBAccess)
        {
            _eComerceDBAccess = eComerceDBAccess;
        }
    }
}
