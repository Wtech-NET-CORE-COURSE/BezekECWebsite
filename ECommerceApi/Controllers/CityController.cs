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
    public class CityController : ControllerBase
    {
        private ICityServices _cityServices;
        public CityController(ICityServices cityServices)
        {
            _cityServices = cityServices;
        }
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<City>>> GetAll()
        {
            var cities = await _cityServices.GetAllCity();
            return Ok(cities);
        }
        [HttpPost("[action]")]
        public async Task<City> Create(City city)
        {
            await _cityServices.CreateCity(city);
            return city;
        }
        [HttpDelete("[action]")]
        public IActionResult Delete(City city)
        {
            if (_cityServices.GetCityById(city.CityId) != null)
            {
                _cityServices.DeleteCity(city);
                return Ok("Deleted city");
            }
            return NotFound();
        }
        [HttpPut("[action]")]
        public IActionResult Put([FromBody] City city)// objeyi body içinde göndereceğimiz anlamına gelmektedir. 
        {
            if (_cityServices.GetCityById(city.CityId) != null)
            {
                return Ok(_cityServices.UpdateCity(city));
            }
            return NotFound();
        }
    }
}
