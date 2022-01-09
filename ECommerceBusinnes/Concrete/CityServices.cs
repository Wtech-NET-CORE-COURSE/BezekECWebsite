using ECommerceBusinnes.Abstract;
using ECommerceDataAccess.Abstract;
using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBusinnes.Concrete
{
    public class CityServices : ICityServices
    {
        private IUnitOfWork _unitOfWork;
        public CityServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<City> CreateCity(City city)
        {
            var result = await _unitOfWork.City.AddAsync(city);
            await _unitOfWork.CommitAsync();
            return result;
        }

        public void DeleteCity(City city)
        {
            _unitOfWork.City.RemoveAsync(city);
            _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<City>> GetAllCity()
        {
            return await _unitOfWork.City.GetAllAsync();
        }

        public async Task<City> GetCityById(int id)
        {
            return await _unitOfWork.City.GetById(id);
        }

        public async Task<City> UpdateCity(City city)
        {
            _unitOfWork.City.Update(city);
            await _unitOfWork.CommitAsync();
            return city;
        }
    }
}
