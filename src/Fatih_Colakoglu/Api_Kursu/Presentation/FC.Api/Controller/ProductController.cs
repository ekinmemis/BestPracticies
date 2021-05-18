using AutoMapper;
using FC.Api.DTOs;
using FC.Api.Filters;
using FC.Core.Models;
using FC.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FC.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<IEnumerable<ProductDto>>(await _productService.GetAllAsync()));
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<ProductDto>(await _productService.GetByIdAsync(id)));
        }

        [ValidationFilter]
        [HttpPost]
        public async Task<IActionResult> Insert(ProductDto dto)
        {
            return Created(string.Empty, await _productService.AddAsync(_mapper.Map<Product>(dto)));
        }

        [ValidationFilter]
        [HttpPut]
        public IActionResult Update(ProductDto dto)
        {
            var product = _productService.Update(_mapper.Map<Product>(dto));
            return NoContent();
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productService.Remove(_productService.GetByIdAsync(id).Result);
            return NoContent();
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}/category")]
        public async Task<IActionResult> GetWithProductById(int id)
        {
            return Ok(_mapper.Map<ProductWithCategoryDto>(await _productService.GetWithCategoryByIdAsync(id)));
        }
    }
}
