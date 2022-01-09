using ECommerceBusinnes.Abstract;
using ECommerceDataAccess.Abstract;
using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBusinnes.Concrete
{
    public class SaleServices : ISaleServices
    {
        private IUnitOfWork _unitOfWork;
        public SaleServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Sale> CreateSale(Sale sale)
        {
            var result = await _unitOfWork.Sale.AddAsync(sale);
            await _unitOfWork.CommitAsync();
            return result;
        }

        public void DeleteSale(Sale sale)
        {
            _unitOfWork.Sale.RemoveAsync(sale);
        }

        public async Task<IEnumerable<Sale>> GetAllSale()
        {
            return await _unitOfWork.Sale.GetAllAsync();
        }

        public async Task<Sale> GetSaleById(int id)
        {
            return await _unitOfWork.Sale.GetById(id);
        }

        public async Task<Sale> UpdateSale(Sale sale)
        {
            _unitOfWork.Sale.Update(sale);
            await _unitOfWork.CommitAsync();
            return sale;
        }
    }
}
