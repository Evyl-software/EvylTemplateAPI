using Application.ProductServices.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using System.Net;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ProductController : BaseApiController
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }        
        [HttpGet]        
        public async Task<IActionResult> GetProduct(ObjectId id)
        {
            var result = await _productService.GetAsync(id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteProduct(ObjectId id)
        {
            var result = await _productService.DeleteAsync(id);
            return Ok(result);
        }
        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            var result = await _productService.UpdateAsync(product);
            return Ok(result);
        }
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            var result = await _productService.UpdateAsync(product);
            return CreatedAtRoute("", result);
        }
    }
}
