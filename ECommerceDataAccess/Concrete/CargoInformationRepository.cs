using ECommerceDataAccess.Abstract;
using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceDataAccess.Concrete
{
    public class CargoInformationRepository : Repository<CargoInformation>, ICargoInformation
    {
        private EComerceDBAccess _eComerceDBAccess;
        public CargoInformationRepository(EComerceDBAccess eComerceDBAccess) : base(eComerceDBAccess)
        {
            _eComerceDBAccess = eComerceDBAccess;
        }
    }
}
