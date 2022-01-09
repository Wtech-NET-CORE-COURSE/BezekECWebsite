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
    public class ProductFeatureController : ControllerBase
    {
        private IProductFeatureServices _productFeatureServices;
        public ProductFeatureController(IProductFeatureServices productFeatureServices)
        {
            _productFeatureServices = productFeatureServices;
        }
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<ProductFeature>>> GetAll()
        {
            var productFeatures = await _productFeatureServices.GetAllProductFeature();
            return Ok(productFeatures);
        }
        [HttpPost("[action]")]
        public async Task<ProductFeature> Create(ProductFeature productFeature)
        {
            await _productFeatureServices.CreateProductFeature(productFeature);
            return productFeature;
        }
        [HttpDelete("[action]")]
        public IActionResult Delete(ProductFeature productFeature)
        {
            if (_productFeatureServices.GetProductFeatureById(productFeature.ProductFeatureId) != null)
            {
                _productFeatureServices.DeleteProductFeature(productFeature);
                return Ok("Deleted product feature");
            }           
            return NotFound();
        }
        [HttpPut("[action]")]
        public IActionResult Put([FromBody] ProductFeature productFeature)
        {
            if (_productFeatureServices.GetProductFeatureById(productFeature.ProductFeatureId) != null )
            {
                return Ok(_productFeatureServices.UpdateProductFeature(productFeature));
            }
            return NotFound();
        }
    }
}
