using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBusinnes.Abstract
{
    public interface ICargoInformationServices
    {
        Task<CargoInformation> CreateCargoInformation(CargoInformation cargoInformation);
        Task<CargoInformation> GetCargoInformationById(int id);
        Task<IEnumerable<CargoInformation>> GetAllCargoInformation();
        Task<CargoInformation> UpdateCargoInformation(CargoInformation cargoInformation);
        void DeleteCargoInformation(CargoInformation cargoInformation);
    }
}
