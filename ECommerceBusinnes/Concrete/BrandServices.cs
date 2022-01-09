using ECommerceBusinnes.Abstract;
using ECommerceDataAccess.Abstract;
using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBusinnes.Concrete
{
    public class BrandServices : IBrandServices
    {
        private IUnitOfWork _unitOfWork;
        public BrandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Brand> CreateBrand(Brand brand)
        {
            var result = await _unitOfWork.Brand.AddAsync(brand);
            await _unitOfWork.CommitAsync();
            return result;
        }

        public void DeleteBrand(Brand brand)
        {
            _unitOfWork.Brand.RemoveAsync(brand);
            _unitOfWork.CommitAsync();
        }

        public async  Task<IEnumerable<Brand>> GetAllBrand()
        {
            return await _unitOfWork.Brand.GetAllAsync();
        }

        public async Task<Brand> GetBrandById(int id)
        {
            return await _unitOfWork.Brand.GetById(id);
        }

        public async Task<Brand> UpdateBrand(Brand brand)
        {
            _unitOfWork.Brand.Update(brand);
            await _unitOfWork.CommitAsync();
            return brand;
        }
    }
}
