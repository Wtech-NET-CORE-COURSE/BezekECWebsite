using ECommerceBusinnes.Abstract;
using ECommerceBusinnes.Concrete;
using ECommerceDataAccess;
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
        private readonly EComerceDBAccess _context;
        public AdressController(IAdressServices adressServices, EComerceDBAccess context)
        {
            _context = context;
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
        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(long id)
        {
            var todoItem = await _context.Adresses.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.Adresses.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
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
        //PUT: api/TodoItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTodoItem(long id, Adress adress)
        {
            if (id != adress.AdressId)
            {
                return BadRequest();
            }

            var todoItem = await _adressServices.GetAdressById(adress.AdressId);
            if (todoItem == null)
            {
                return NotFound();
            }

            todoItem.AdressName = adress.AdressName;
            //todoItem.IsComplete = todoItemDTO.IsComplete;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!TodoItemExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }
        private bool TodoItemExists(long id)
        {
            return _context.Adresses.Any(e => e.AdressId == id);
        }

    }
}
