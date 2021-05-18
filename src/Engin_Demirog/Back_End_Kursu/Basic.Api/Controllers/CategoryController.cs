using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Basic.Business.Abstract;
using Basic.Entities.Concrete;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("{id}")]
        public IActionResult Where(int id)
        {
            var result = _categoryService.Where(f => f.CategoryID == id);
            if (result.Success)
                return Ok(result.Data);
            else
                return BadRequest(result.Message);
        }

        [HttpPost]
        public IActionResult Insert(Categories category)
        {
            var result = _categoryService.Insert(category);

            if (result.Success)
                return Created(string.Empty, result.Message);
            else
                return BadRequest(result.Message);
        }

        [HttpPut]
        public IActionResult Update(Categories category)
        {
            var result = _categoryService.Update(category);

            if (result.Success)
                return Ok(result.Message);
            else
                return BadRequest(result.Message);
        }

        [HttpDelete("{categoryId}")]
        public IActionResult Delete(int categoryId)
        {
            var entity = _categoryService.GetCategoryById(categoryId);
            var result = _categoryService.Delete(entity.Data);

            if (result.Success)
                return Ok(result.Message);
            else
                return BadRequest(result.Message);
        }
    }
}
