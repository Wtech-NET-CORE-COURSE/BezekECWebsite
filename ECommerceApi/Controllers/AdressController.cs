using ECommerceBusinnes.Abstract;
using ECommerceBusinnes.Concrete;
using ECommerceEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        /// id denemesi
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //// GET: api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Adress>> GetById(int id)
        {
            var idFind = await _adressServices.GetAdressById(id);

            if (idFind == null)
            {
                return NotFound();
            }

            return idFind;
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
        // PUT: api/TodoItems/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateTodoItem(long id, Adress adress)
        //{
        //    if (id != adress.AdressId)
        //    {
        //        return BadRequest();
        //    }

        //    var todoItem = await _adressServices.GetAdressById(adress.AdressId);
        //    if (todoItem == null)
        //    {
        //        return NotFound();
        //    }

        //    todoItem.AdressName = adress.AdressName;
            //todoItem.IsComplete = todoItemDTO.IsComplete;

            //try
            //{
            //    await _adressServices.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException) when (!TodoItemExists(id))
            //{
            //    return NotFound();
            //}

            //return NoContent();
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAdressId(long id, Adress adress)
        //{
        //    if (id != adress.AdressId)
        //    {
        //        return BadRequest();//geçersiz istek
        //    }

        //    _context.Entry(adress).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TodoItemExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}
    }
}
