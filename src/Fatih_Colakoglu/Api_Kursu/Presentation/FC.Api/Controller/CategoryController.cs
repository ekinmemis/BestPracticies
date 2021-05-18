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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(await _categoryService.GetAllAsync()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<CategoryDto>(await _categoryService.GetByIdAsync(id)));
        }

        [HttpGet("{id}/products")]
        public async Task<IActionResult> GetWithProductById(int id)
        {
            return Ok(_mapper.Map<CategoryWithProductDto>(await _categoryService.GetWithProductsByIdAsync(id)));
        }

        [ValidationFilter]
        [HttpPost]
        public async Task<IActionResult> Insert(CategoryDto dto)
        {
            return Created(string.Empty, _mapper.Map<CategoryDto>(await _categoryService.AddAsync(_mapper.Map<Category>(dto))));
        }

        [ValidationFilter]
        [HttpPut]
        public IActionResult Update(CategoryDto dto)
        {
            _categoryService.Update(_mapper.Map<Category>(dto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _categoryService.Remove(_categoryService.GetByIdAsync(id).Result);
            return NoContent();
        }
      
    }
}
