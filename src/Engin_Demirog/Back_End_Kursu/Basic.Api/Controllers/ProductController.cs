using Basic.Business.Abstract;
using Basic.Entities.Concrete;

using Microsoft.AspNetCore.Mvc;

namespace Basic.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("{id}")]
        public IActionResult Where(int id)
        {
            var result = _productService.Where(f => f.ProductID == id);
            if (result.Success)
                return Ok(result.Data);
            else
                return BadRequest(result.Message);
        }

        [HttpGet("{id}/cateogry")]
        public IActionResult GetProductsByCategoryId(int categoryId)
        {
            var result = _productService.GetProductsByCategoryId(categoryId);
            if (result.Success)
                return Ok(result.Data);
            else
                return BadRequest(result.Message);
        }

        [HttpPost]
        public IActionResult Insert(Products product)
        {
            var result = _productService.Insert(product);

            if (result.Success)
                return Created(string.Empty, result.Message);
            else
                return BadRequest(result.Message);
        }

        [HttpPut]
        public IActionResult Update(Products product)
        {
            var result = _productService.Update(product);

            if (result.Success)
                return Ok(result.Message);
            else
                return BadRequest(result.Message);
        }

        [HttpDelete("{productId}")]
        public IActionResult Delete(int productId)
        {
            var entity = _productService.GetProductById(productId);
            var result = _productService.Delete(entity.Data);

            if (result.Success)
                return Ok(result.Message);
            else
                return BadRequest(result.Message);
        }
    }
}