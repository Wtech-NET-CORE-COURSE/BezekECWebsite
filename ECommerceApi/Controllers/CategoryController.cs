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
    public class CategoryController : ControllerBase
    {
        private ICategoryServices _categoryServices;
        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Category>>> GetAll()
        {
            var categories = await _categoryServices.GetAllCategory();
            return Ok(categories);
        }
    }
}
