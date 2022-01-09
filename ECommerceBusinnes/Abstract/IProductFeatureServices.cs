using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBusinnes.Abstract
{
    public interface IProductFeatureServices
    {
        Task<ProductFeature> CreateProductFeature(ProductFeature productFeature);
        Task<ProductFeature> GetProductFeatureById(int id);
        Task<IEnumerable<ProductFeature>> GetAllProductFeature();
        Task<ProductFeature> UpdateProductFeature(ProductFeature productFeature);
        void DeleteProductFeature(ProductFeature productFeature);
    }
}
