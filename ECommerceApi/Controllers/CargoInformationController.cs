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
    public class CargoInformationController : ControllerBase
    {
        private ICargoInformationServices _cargoInformationServices;
        public CargoInformationController(ICargoInformationServices cargoInformationServices)
        {
            _cargoInformationServices = cargoInformationServices;
        }
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<CargoInformation>>> Get()
        {
            var cargoInformations = await _cargoInformationServices.GetAllCargoInformation();
            return Ok(cargoInformations);
        }
        [HttpPost("[action]")]
        public async Task<CargoInformation> Create(CargoInformation cargoInformation)
        {
            await _cargoInformationServices.CreateCargoInformation(cargoInformation);
            return cargoInformation;
        }
        [HttpDelete("[action]")]
        public IActionResult Delete(CargoInformation cargoInformation)
        {
            if (_cargoInformationServices.GetCargoInformationById(cargoInformation.CargoId) != null)
            {
                _cargoInformationServices.DeleteCargoInformation(cargoInformation);
                return Ok("Deleted Cargo Information");
            }
            return NotFound();
        }
        [HttpPut("[action]")]
        public IActionResult Put([FromBody] CargoInformation cargoInformation)
        {
            if (_cargoInformationServices.GetCargoInformationById(cargoInformation.CargoId) != null)
            {
                return Ok(_cargoInformationServices.UpdateCargoInformation(cargoInformation)); 
            }
            return NotFound();
        }
    }
}
