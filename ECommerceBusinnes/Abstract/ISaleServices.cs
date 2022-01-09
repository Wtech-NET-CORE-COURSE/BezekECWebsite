using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBusinnes.Abstract
{
    public interface ISaleServices
    {
        Task<Sale> CreateSale(Sale sale);
        Task<Sale> GetSaleById(int id);
        Task<IEnumerable<Sale>> GetAllSale();
        Task<Sale> UpdateSale(Sale sale);
        void DeleteSale(Sale sale);
    }
}
