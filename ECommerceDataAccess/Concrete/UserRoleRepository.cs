using ECommerceDataAccess.Abstract;
using ECommerceEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceDataAccess.Concrete
{
    public class UserRoleRepository : Repository<UserRole>, IUserRole
    {
        private EComerceDBAccess _eComerceDBAccess;
        public UserRoleRepository(EComerceDBAccess eComerceDBAccess) : base(eComerceDBAccess) => _eComerceDBAccess = eComerceDBAccess;

    }
}
