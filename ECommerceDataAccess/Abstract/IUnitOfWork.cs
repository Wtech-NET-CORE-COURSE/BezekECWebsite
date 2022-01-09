using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceDataAccess.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> CommitAsync();
        IAddress Address { get; }
        IBrand Brand { get; }
        ICargoInformation CargoInformation { get; }
        ICategory Category { get; }
        ICity City { get; }
        IDistrict District { get; }
        IProduct Product { get; }
        IProductFeature ProductFeature { get; }
        ISale Sale { get; }
        ISeller Seller { get; }
    }
}
