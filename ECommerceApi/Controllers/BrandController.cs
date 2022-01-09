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
    public class BrandController : ControllerBase
    {
        private IBrandServices _brandServices;
        public BrandController(IBrandServices brandServices)
        {
            _brandServices = brandServices;
        }
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Brand>>> Get()
        {
            var brands = await _brandServices.GetAllBrand();
            return Ok(brands);
        }
        [HttpPost("[action]")]
        public async Task<Brand> Create(Brand brand)
        {
            await _brandServices.CreateBrand(brand);
            return brand;
        }

    }
}
