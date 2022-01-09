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
    public class DistrictController : ControllerBase
    {
        private IDistrictServices _districtServices;
        public DistrictController(IDistrictServices districtServices)
        {
            _districtServices = districtServices;
        }
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<District>>> GetAll()
        {
            var districts = await _districtServices.GetAllDistrict();
            return Ok(districts);
        }
        [HttpPost("[action]")]
        public async Task<District> Create(District district)
        {
            await _districtServices.CreateDistrict(district);
            return district;
        }
    }
}
