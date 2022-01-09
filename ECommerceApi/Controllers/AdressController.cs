using ECommerceBusinnes.Abstract;
using ECommerceBusinnes.Concrete;
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
    public class AdressController : ControllerBase
    {
        private IAdressServices _adressServices;
        public AdressController(IAdressServices adressServices)
        {
            _adressServices = adressServices;
        }
        /// <summary>
        /// retrieve
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Adress>>>  Get()
        {
            var adress = await _adressServices.GetAllAdress();
            return Ok(adress);
        }
        /// <summary>
        /// update
        /// </summary>
        /// <param name="adress"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<Adress> Create([FromBody] Adress adress)
        {
            await _adressServices.CreateAdress(adress);
            return adress;
        }

        
        [HttpDelete("[action]")]
        public IActionResult Delete(Adress adress)
        {
            if (_adressServices.GetAdressById(adress.AdressId) != null)
            {
                _adressServices.DeleteAdress(adress);
                return Ok("Deleted adress");
            }
            return NotFound();
        }
        /// <summary>
        /// create
        /// </summary>
        /// <param name="adress"></param>
        /// <returns></returns>
        [HttpPut("[action]")]
        public IActionResult Put([FromBody] Adress adress)
        {
            if (_adressServices.GetAdressById(adress.AdressId) != null)
            {
                return Ok(_adressServices.UpdateAdress(adress));
            }
            return NotFound();
        }
    }
}
