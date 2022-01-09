using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBusinnes.Abstract
{
    public interface ICityServices
    {
        Task<City> CreateCity(City city);
        Task<City> GetCityById(int id);
        Task<IEnumerable<City>> GetAllCity();
        Task<City> UpdateCity(City city);
        void DeleteCity(City city);
    }
}
