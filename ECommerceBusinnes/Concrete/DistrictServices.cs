using ECommerceBusinnes.Abstract;
using ECommerceDataAccess.Abstract;
using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBusinnes.Concrete
{
    public class DistrictServices : IDistrictServices
    {
        private IUnitOfWork _unitOfWork;
        public DistrictServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<District> CreateDistrict(District district)
        {
            var result = await _unitOfWork.District.AddAsync(district);
            await _unitOfWork.CommitAsync();
            return result;
        }

        public void DeleteDistrict(District district)
        {
            _unitOfWork.District.RemoveAsync(district);
            _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<District>> GetAllDistrict()
        {
           return await _unitOfWork.District.GetAllAsync();
        }

        public async Task<District> GetDistrictById(int id)
        {
            return await _unitOfWork.District.GetById(id);
        }

        public async Task<District> UpdateDistrict(District district)
        {
            _unitOfWork.District.Update(district);
            await _unitOfWork.CommitAsync();
            return district;

        }
    }
}
