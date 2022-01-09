using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBusinnes.Abstract
{
    public interface IBrandServices
    {
        Task<Brand> CreateBrand(Brand brand);
        Task<Brand> GetBrandById(int id);
        Task<IEnumerable<Brand>> GetAllBrand();
        Task<Brand> UpdateBrand(Brand brand);
        void DeleteBrand(Brand brand);
    }
}
