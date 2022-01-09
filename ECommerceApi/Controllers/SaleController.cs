using ECommerceBusinnes.Abstract;
using ECommerceEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private ISaleServices _saleServices;
        public SaleController(ISaleServices saleServices)
        {
            _saleServices = saleServices;
        }
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Sale>>> GetAll()
        {
            var sales = await _saleServices.GetAllSale();
            return Ok(sales);
        }
        [HttpPost("[action]")]
        public async Task<Sale> Create(Sale sale)
        {
            await _saleServices.CreateSale(sale);
            return sale;
        }
    }
}
