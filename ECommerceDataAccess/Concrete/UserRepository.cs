using ECommerceDataAccess.Abstract;
using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceDataAccess.Concrete
{
    public class UserRepository : Repository<User>, IUser
    {
        private EComerceDBAccess _eComerceDBAccess;
        //{
        //    get { return Context as EComerceDBAccess; }
        //}
        public UserRepository(EComerceDBAccess eComerceDBAccess) : base(eComerceDBAccess) => _eComerceDBAccess = eComerceDBAccess;
    }
}
