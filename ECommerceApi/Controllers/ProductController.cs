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
    public class ProductController : ControllerBase
    {
        private IProductServices _productServices;
        public ProductController(IProductServices productServices) => this._productServices = productServices;

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            var products = await _productServices.GetAllProduct();
            return Ok(products);
        }
        [HttpPost("[action]")]
        public async Task<Product> Create(Product product)
        {
            await _productServices.CreateProduct(product);
            return product;
        }
        [HttpDelete("[action]")]
        public IActionResult Delete(Product product)
        {
            if (_productServices.GetProductById(product.ProductId) != null)
            {
                _productServices.DeleteProduct(product);
                return Ok("Deleted product");
            }
            return NotFound();
        }
        [HttpPut("[action]")]
        public IActionResult Put([FromBody] Product product)
        {
            if (_productServices.GetProductById(product.ProductId) != null)
            {
                return Ok(_productServices.UpdateProduct(product));
            }
            return NotFound();
        }
    }
}
