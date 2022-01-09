using ECommerceBusinnes.Abstract;
using ECommerceDataAccess.Abstract;
using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBusinnes.Concrete
{
    public class CargoInformationServices : ICargoInformationServices
    {
        private IUnitOfWork _unitOfWork;
        public CargoInformationServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<CargoInformation> CreateCargoInformation(CargoInformation cargoInformation)
        {
            var result = await _unitOfWork.CargoInformation.AddAsync(cargoInformation);
            await _unitOfWork.CommitAsync();
            return result;
        }

        public void DeleteCargoInformation(CargoInformation cargoInformation)
        {
            _unitOfWork.CargoInformation.RemoveAsync(cargoInformation);
            _unitOfWork.CommitAsync();
        }

        public async  Task<IEnumerable<CargoInformation>> GetAllCargoInformation()
        {
            return await _unitOfWork.CargoInformation.GetAllAsync();
        }

        public async Task<CargoInformation> GetCargoInformationById(int id)
        {
            return await _unitOfWork.CargoInformation.GetById(id);
        }

        public async Task<CargoInformation> UpdateCargoInformation(CargoInformation cargoInformation)
        {
            _unitOfWork.CargoInformation.Update(cargoInformation);
            await _unitOfWork.CommitAsync();
            return cargoInformation;
        }
    }
}
