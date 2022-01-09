using ECommerceDataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceDataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private EComerceDBAccess _eCommerceDBAccess;
        private AddressRepository addressRepository;
        private BrandRepository brandRepository;
        private CargoInformationRepository cargoInformationRepository;
        private CategoryRepository categoryRepository;
        private CityRepository cityRepository;
        private DistrictRepository districtRepository;
        private ProductFeatureRepository productFeatureRepository;
        private ProductRepository productRepository;
        private SaleRepository saleRepository;
        private SellerRepository sellerRepository;
        public UnitOfWork(EComerceDBAccess eComerceDBAccess) 
        {
            _eCommerceDBAccess = eComerceDBAccess;
        }
        public IAddress Address => addressRepository = addressRepository ?? new AddressRepository(_eCommerceDBAccess);
        public IBrand Brand => brandRepository = brandRepository ?? new BrandRepository(_eCommerceDBAccess);
        public ICargoInformation CargoInformation => cargoInformationRepository = cargoInformationRepository ?? new CargoInformationRepository(_eCommerceDBAccess);
        public ICategory Category => categoryRepository = categoryRepository ?? new CategoryRepository(_eCommerceDBAccess);
        public ICity City => cityRepository = cityRepository ?? new CityRepository(_eCommerceDBAccess);
        public IDistrict District => districtRepository = districtRepository ?? new DistrictRepository(_eCommerceDBAccess);
        public IProductFeature ProductFeature => productFeatureRepository = productFeatureRepository ?? new ProductFeatureRepository(_eCommerceDBAccess);
        public IProduct Product => productRepository = productRepository ?? new ProductRepository(_eCommerceDBAccess);
        public ISale Sale => saleRepository = saleRepository ?? new SaleRepository(_eCommerceDBAccess);
        public ISeller Seller => sellerRepository = sellerRepository ?? new SellerRepository(_eCommerceDBAccess);

        public async Task<int> CommitAsync()
        {
            return await _eCommerceDBAccess.SaveChangesAsync();
        }

        public void Dispose()
        {
            _eCommerceDBAccess.Dispose();
        }
    }
}
