using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBusinnes.Abstract
{
    public interface IDistrictServices
    {
        Task<District> CreateDistrict(District district);
        Task<District> GetDistrictById(int id);
        Task<IEnumerable<District>> GetAllDistrict();
        Task<District> UpdateDistrict(District district);
        void DeleteDistrict(District district);
    }
}
