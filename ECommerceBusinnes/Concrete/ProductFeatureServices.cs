using ECommerceBusinnes.Abstract;
using ECommerceDataAccess.Abstract;
using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBusinnes.Concrete
{
    public class ProductFeatureServices : IProductFeatureServices
    {
        private IUnitOfWork _unitOfWork;
        public ProductFeatureServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<ProductFeature> CreateProductFeature(ProductFeature productFeature)
        {
            var result =await _unitOfWork.ProductFeature.AddAsync(productFeature);
            await _unitOfWork.CommitAsync();
            return result;
        }

        public void DeleteProductFeature(ProductFeature productFeature)
        {
            _unitOfWork.ProductFeature.RemoveAsync(productFeature);
        }

        public async Task<IEnumerable<ProductFeature>> GetAllProductFeature()
        {
            return await _unitOfWork.ProductFeature.GetAllAsync();
        }

        public async Task<ProductFeature> GetProductFeatureById(int id)
        {
            return await _unitOfWork.ProductFeature.GetById(id);
        }

        public async Task<ProductFeature> UpdateProductFeature(ProductFeature productFeature)
        {
            _unitOfWork.ProductFeature.Update(productFeature);
            await _unitOfWork.CommitAsync();
            return productFeature;
        }
    }
}
